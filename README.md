## Usage

```csharp

// register your username and password into the genymotion (gmtool) tool.
var settings = new GenymotionConfigSettings()
{
		Username = "genymotion.com username",
		Password = "genymotion.com password",
};

ConfigureGenymotion(settings);

// activate the software license on this computer
var licenseKey = "hello-123-world-a-b-c-d";
RegisterGenymotionLicense(licenseKey);


// factory reset, then power on first simulator and then connect it to ADB.
IReadonlyList<GenymotionAdminListResukt> simulators = ListGenymotionSimulators();

var firstSimulator = simulators.First();
var deviceIdentifier = firstSimulator.UUID;

FactoryResetGenymotionSimulator(deviceIdentifier);
StartGenymotionSimulator(deviceIdentifier);
AdbConnectGenymotionSimulator(deviceIdentifier)
```

### List Installed Simulators

```csharp
IReadonlyList<GenymotionAdminListResult> ListGenymotionSimulators();

public class GenymotionAdminListResult
{
		public string IpAddress { get; set; }
		public string Name { get; set; }
		public string State { get; set; }	 // "On", "Off", "Aborted"
		public string UUID { get; set; }
}
```

### Administration

```csharp
void FactoryResetGenymotionSimulator(string deviceIdentifier);
void StopGenymotionSimulator(string deviceIdentifier)
void StartGenymotionSimulator(string deviceIdentifier)
void AdbConnectGenymotionSimulator(string deviceIdentifier);
void AdbDisconnectGenymotionSimulator(string deviceIdentifier);
```

### Configuration

```csharp
var settings = new GenymotionConfigSettings()
{
		Username = "genymotion.com username",
		Password = "genymotion.com password",
};

void ConfigureGenymotion(settings);
```

### Licensing

You must configure your username and password before registering the license, this is a Genymotion restriction.

```csharp
void RegisterGenymotionLicense(string licenseKey);
```

### Exit Codes

```
RETURN_NO_ERROR                = 0
RETURN_NO_SUCH_ACTION          = 1
RETURN_BAD_PARAM_VALUE         = 2
RETURN_COMMAND_FAILED          = 3
RETURN_VMENGINE_ERROR          = 4
RETURN_DEVICE_NOT_FOUND        = 5
RETURN_CANT_LOGIN              = 6
RETURN_CANT_REGISTER_LICENSE   = 7
RETURN_CANT_ACTIVATE_LICENSE   = 8
RETURN_NO_ACTIVATED_LICENSE    = 9
RETURN_INVALID_LICENSE         = 10
RETURN_MISSING_ARGUMENTS       = 11
RETURN_VM_NOT_STOPPED          = 12
RETURN_LICENSE_REQUIRED        = 13
RETURN_COMMAND_NOT_FOUND_UNIX  = 127
RETURN_SIGTERM                 = 143
```

See https://github.com/Genymobile/genymotion-gradle-plugin/blob/master/plugin/src/main/groovy/com/genymotion/tools/GMTool.groovy#L122

# cli locations
* /Applications/Genymotion.app/Contents/MacOS/gmtool
