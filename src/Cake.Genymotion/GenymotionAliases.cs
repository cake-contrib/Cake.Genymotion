using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.Tooling;
using Cake.Genymotion.Admin;
using Cake.Genymotion.Device;
using Cake.Genymotion.License;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cake.Genymotion
{
    [CakeAliasCategory("Genymotion")]
    public static class GenymotionAliases
    {
        [CakeMethodAlias]
        public static void AdbConnectGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionDeviceSettings settings = null)
        {
            var runner = new GenymotionDeviceRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings ?? new GenymotionDeviceSettings());
            runner.AdbConnect(deviceIdentifier);
        }

        [CakeMethodAlias]
        public static void AdbDisconnectGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionDeviceSettings settings = null)
        {
            var runner = new GenymotionDeviceRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings ?? new GenymotionDeviceSettings());
            runner.AdbDisconnect(deviceIdentifier);
        }

        [CakeMethodAlias]
        public static void FactoryResetGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionAdminSettings settings = null)
        {
            var runner = new GenymotionAdminRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings ?? new GenymotionAdminSettings());
            runner.FactoryReset(deviceIdentifier);
        }

        [CakeMethodAlias]
        public static IReadOnlyList<GenymotionAdminListResult> ListGenymotionSimulators(this ICakeContext context, GenymotionAdminSettings settings = null)
        {
            var runner = new GenymotionAdminRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings ?? new GenymotionAdminSettings());
            return runner.List().ToList().AsReadOnly();
        }

        [CakeMethodAlias]
        public static void RegisterGenymotionLicense(this ICakeContext context, string licenseKey, GenymotionLicenseSettings settings = null)
        {
            var runner = new GenymotionLicenseRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings ?? new GenymotionLicenseSettings());
            runner.Register(licenseKey);
        }

        [CakeMethodAlias]
        public static void ResetAllGenymotionSimulators(this ICakeContext context, GenymotionAdminSettings settings = null)
        {
            throw new NotImplementedException();
        }

        [CakeMethodAlias]
        public static void ResetGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionAdminSettings settings = null)
        {
            var runner = new GenymotionAdminRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings ?? new GenymotionAdminSettings());
            runner.Reset(deviceIdentifier);
        }

        [CakeMethodAlias]
        public static void StartGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionAdminSettings settings = null)
        {
            var runner = new GenymotionAdminRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings ?? new GenymotionAdminSettings());
            runner.Stop(deviceIdentifier);
        }

        [CakeMethodAlias]
        public static void StopAllGenymotionSimulators(this ICakeContext context, GenymotionAdminSettings settings = null)
        {
            throw new NotImplementedException();
        }

        [CakeMethodAlias]
        public static void StopGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionAdminSettings settings = null)
        {
            var runner = new GenymotionAdminRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings ?? new GenymotionAdminSettings());
            runner.Stop(deviceIdentifier);
        }
    }
}