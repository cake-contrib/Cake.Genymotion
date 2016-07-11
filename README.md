# design rules
- will throw if not running on osx

# method names
- void ResetAppleSimulator(string deviceId);
- void ShutdownAllSimulators();
- void ResetAllAppleSimulators();
- Dict<string, guid> AppleSimulators();

# future

	create              Create a new device.
	delete              Delete a device or all unavailable devices.
	pair                Create a new watch and phone pair.
	unpair              Unpair a watch and phone pair.
	pair_activate       Set a given pair as active.
	erase               Erase a device's contents and settings.
	boot                Boot a device.
	shutdown            Shutdown a device.
	rename              Rename a device.
	getenv              Print an environment variable from a running device.
	openurl             Open a URL in a device.
	addphoto            Add photos to the photo library of a device.
	addvideo            Add videos to the photo library of a device.
	install             Install an app on a device.
	uninstall           Uninstall an app from a device.
	get_app_container   Print the path of the intsalled app's container
	launch              Launch an application by identifier on a device.
	spawn               Spawn a process on a device.
	list                List available devices, device types, runtimes, or device pairs.
	icloud_sync         Trigger iCloud sync on a device.
	help                Prints the usage for a given subcommand.