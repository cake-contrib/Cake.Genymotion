
#addin "nuget:http://localhost:3128/api/odata?package=Cake.Genymotion"
using Cake.Genymotion;

Task("RunIntegrationTests")
    .Does (() =>
{
    var simulators = ListGenymotionSimulators(new GenymotionAdminSettings() { ToolPath = @"C:\Program Files\Genymobile\Genymotion\gmtool.exe"});
    foreach (var simulator in simulators)
    {
        Information(string.Format("Name={0}, UUID={1}, State={2}, IpAddress={3}", simulator.Name, simulator.UUID, simulator.State, simulator.IpAddress));
    }

    const string deviceIdentifier = "cba69bf3-1658-4027-80e7-df5c37a35db5";

    Information("Reseting");
    FactoryResetGenymotionSimulator(deviceIdentifier, new GenymotionAdminSettings() { ToolPath = @"C:\Program Files\Genymobile\Genymotion\gmtool.exe"});
    FactoryResetGenymotionSimulator(deviceIdentifier);

    Information("Starting");
    StartGenymotionSimulator(deviceIdentifier, new GenymotionAdminSettings() { Timeout = 600 });

    Information("Connecting");
    AdbConnectGenymotionSimulator(deviceIdentifier);

    Information("Disconnecting");
    AdbDisconnectGenymotionSimulator(deviceIdentifier);

    Information("Stopping");
    StopGenymotionSimulator(deviceIdentifier);

});

RunTarget("RunIntegrationTests");
