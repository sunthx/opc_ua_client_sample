# OPC UA Client Sample

使用 OPCFoundation 开源 [UA-.NETStandard](https://github.com/OPCFoundation/UA-.NETStandard) 

```csharp
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
```

