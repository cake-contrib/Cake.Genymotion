# design rules
- will throw if not running on osx but windows can be supported in the future.
- will throw if return code is not 0.
- will throw if device cannot be found.

# configuration
- commndTimeout (timespan in seconds) - share this with the process execution timeout + 30 seconds.
- proxyserver address (string)
- proxyserver port (string)
- proxyserver auth (string)
- proxyserver username (string)
- proxyserver password (string)

# error/return codes

https://github.com/Genymobile/genymotion-gradle-plugin/blob/master/plugin/src/main/groovy/com/genymotion/tools/GMTool.groovy#L122

```
public static final int RETURN_NO_ERROR                = 0
public static final int RETURN_NO_SUCH_ACTION          = 1
public static final int RETURN_BAD_PARAM_VALUE         = 2
public static final int RETURN_COMMAND_FAILED          = 3
public static final int RETURN_VMENGINE_ERROR          = 4
public static final int RETURN_DEVICE_NOT_FOUND        = 5
public static final int RETURN_CANT_LOGIN              = 6
public static final int RETURN_CANT_REGISTER_LICENSE   = 7
public static final int RETURN_CANT_ACTIVATE_LICENSE   = 8
public static final int RETURN_NO_ACTIVATED_LICENSE    = 9
public static final int RETURN_INVALID_LICENSE         = 10
public static final int RETURN_MISSING_ARGUMENTS       = 11
public static final int RETURN_VM_NOT_STOPPED          = 12
public static final int RETURN_LICENSE_REQUIRED        = 13
public static final int RETURN_COMMAND_NOT_FOUND_UNIX  = 127
public static final int RETURN_SIGTERM                 = 143
```

# methods

<T>
	- ipAddress (string)
	- uuid (string)
	- name (string)

- <T> ListGenymotionSimulators();

- void RegisterGenymotionLicense(string);

- void ConnectGenymotionSimulator(uuid/name)
- void DisconnectGenymotionSimulator(uuid/name)
- void StartGenymotionSimulator(uuid/name)
- void StopGenymotionSimulator(uuid/name)
- void ResetGenymotionSimulator(uuid / name)
- void ShutdownGenymotionSimulator(uuid / name);

- void ResetAllGenymotionSimulators();
- void ShutdownAllGenymotionSimulators();

# data that needs parsing

 State  |   IP Address    |                UUID                |      Name
--------+-----------------+------------------------------------+---------------
     On | [Debug] VBoxManage ("guestproperty", "get", "Google Nexus 6P - 6.0.0 - API 23 - 1440x2560", "androvm_ip_management") returns 0
 192.168.57.101 |b08735dd-3cc9-4d60-bc7a-b71f60f3b70b| Google Nexus 6P - 6.0.0 - API 23 - 1440x2560
    Off |         0.0.0.0 |bac4e34e-0a2f-4c66-9bda-be5e1266cef6| Google Nexus 6 - 5.1.0 - API 22 - 1440x2560
    Off |         0.0.0.0 |feb5e979-b52d-4cb2-9610-aeec57ca526a| Google Nexus 6 - 5.0.0 - API 21 - 1440x2560
    Off |         0.0.0.0 |f194407f-4283-41e7-a465-164da6914f64| Google Nexus 5 - 4.4.4 - API 19 - 1080x1920
    Off |         0.0.0.0 |2a0f4213-f228-4938-a87b-1506c27485be| Google Nexus 4 - 4.3 - API 18 - 768x1280
    Off |         0.0.0.0 |2b115107-a7b4-477b-8ae6-22a87c4b9045| Google Nexus 4 - 4.2.2 - API 17 - 768x1280
    Off |         0.0.0.0 |ed3d41c7-0a15-427d-9d05-bedf88ad023d| Google Nexus 4 - 4.1.1 - API 16 - 768x1280


