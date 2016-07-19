
#addin "nuget:http://geoffrey-pc:3128/api/odata?package=Cake.Genymotion"
using Cake.Genymotion;

Task("RunIntegrationTests")
    .Does (() =>
{
    var simulators = ListGenymotionSimulators();
    foreach (var simulator in simulators)
    {
        Information(string.Format("Name={0}, UUID={1}, State={2}, IpAddress={3}", simulator.Name, simulator.UUID, simulator.State, simulator.IpAddress));
    }

    var deviceIdentifier = simulators.First().UUID;

    Information("Reseting");
    //FactoryResetGenymotionSimulator(deviceIdentifier, new GenymotionAdminSettings() { ToolPath = @"C:\Program Files\Genymobile\Genymotion\gmtool.exe"});
    //FactoryResetGenymotionSimulator(deviceIdentifier, new GenymotionAdminSettings() { ToolPath = @"/Applications/Genymotion.app/Contents/MacOS/gmtool"});
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
