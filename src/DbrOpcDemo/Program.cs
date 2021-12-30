using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Configuration;

namespace DbrOpcDemo
{
    internal class Program
    {
        private static readonly string _endPointUrl = "opc.tcp://192.168.0.217:4840";

        private Dictionary<string, string> _keys = new Dictionary<string, string>
        {
            { "PV", "ns=2;i=9" },
            { "SP", "ns=2;i=10" },
            { "OP", "ns=2,i=11" }
        };
        
        public static async Task Main(string[] args)
        {
            var instance = new ApplicationInstance
            {
                ApplicationName = "OPC UA Client",
                ApplicationType = ApplicationType.Client,
                ConfigSectionName = "OPC_UA"
            };

            // create configuration object 
            var configuration = await instance.LoadApplicationConfiguration(false).ConfigureAwait(false);
            await instance.CheckApplicationInstanceCertificate(false, 0);
            
            // create the endpoint
            var collection = new ConfiguredEndpointCollection();
            var endPoint = collection.Create(_endPointUrl);

            // get endpoint description by discover server
            var discoveryServer = endPoint.Description.Server;
            EndpointDescription endpointDescription = default;
            foreach (var discoveryServerDiscoveryUrl in discoveryServer.DiscoveryUrls)
            {
                var uri = Utils.ParseUri(discoveryServerDiscoveryUrl);
                if (uri == null) 
                    continue;
                
                var endpointConfiguration = EndpointConfiguration.Create(configuration);
                var client = DiscoveryClient.Create(
                    uri,
                    endpointConfiguration,
                    configuration);
                    
                var endpointDescriptionCollection= client.GetEndpoints(null);
                if (endpointDescriptionCollection.Count <= 0) 
                    continue;
                
                endpointDescription = endpointDescriptionCollection[0];
                break;
            }
            
            //update endpoint description
            endPoint.Update(endpointDescription);
            
            //create the session channel
            var channel = SessionChannel.Create(
                configuration,
                endPoint.Description,
                endPoint.Configuration,
                default,
                default,
                configuration.CreateMessageContext(true)
            );

            // create the session
            var session = new Session(
                channel,
                configuration,
                endPoint,
                default
            );
            
            session.ReturnDiagnostics = DiagnosticsMasks.All;

            //open the session
            session.Open(
                "BDR",
                (uint)session.SessionTimeout,
                default,
                default,
                true
            );

            // use the session to read/write/call/sub/pub/...
        }
    }
}