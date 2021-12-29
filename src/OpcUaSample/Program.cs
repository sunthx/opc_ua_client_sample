using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Configuration;

namespace OpcUaSample
{
    internal class Program
    {
        private static AutoResetEvent _lock;
        private static readonly string _endPointUrl = "opc.tcp://192.168.0.217:4840";

        private static Dictionary<string, string> _nodeTags = new Dictionary<string, string>
        {
            { "PV", "ns=2;i=9" }
        };

        //1. ApplicationInstance
        //2. ConfiguredEndpoint

        public static async Task Main(string[] args)
        {
            // ApplicationInstance
            var instance = new ApplicationInstance();
            instance.ApplicationName = "DBR Control Client";
            instance.ApplicationType = ApplicationType.Client;
            instance.ConfigSectionName = "DBR.Control.Client";

            // ApplicationConfiguration
            var configuration = await instance.LoadApplicationConfiguration(false).ConfigureAwait(false);
            await instance.CheckApplicationInstanceCertificate(false, 0);
            
            // ServiceMessageContext
            var serviceMessageContext = configuration.CreateMessageContext();
            var collection = new ConfiguredEndpointCollection();

            //通过终结点地址创建一个终结点对象（包含终结点的描述等信息）
            var endPoint = collection.Create(_endPointUrl);
            
            // 默认 SecurityPolicy = None
            // create the channel.
            ITransportChannel channel = SessionChannel.Create(
                configuration,
                endPoint.Description,
                endPoint.Configuration,
                default,
                default,
                configuration.CreateMessageContext(true) 
            );
            
            // create the session
            Session session = new Session(
                channel,
                configuration,
                endPoint,
                default
            );
            session.ReturnDiagnostics = DiagnosticsMasks.All;
            
            //open the session
            //匿名访问
            IUserIdentity userIdentity = null;
            session.Open(
                "BDR",
                (uint)session.SessionTimeout,
                userIdentity,
                default,
                true
                );

            if (!session.Connected)
            {
                Console.WriteLine("Session Connect Failed.");
            }
            else
            {
                var value = session.ReadNode(new NodeId("ns=2;i=9"));
            }
            
            
            Console.ReadKey();
        }

        private static void PrintTagValue(string tagName, string tag)
        {
            //var tagValue = _client.ReadNode(tag);
            //Console.WriteLine($"{tagName}:{tagValue}");
        }

        private static void ClientOnConnectComplete(object sender, EventArgs e)
        {
            Console.WriteLine("------------- Connected -------------");
            _lock.Set();
        }
    }
}