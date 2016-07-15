using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.Tooling;
using Cake.Genymotion.Admin;
using Cake.Genymotion.Device;
using Cake.Genymotion.License;
using System;
using System.Collections.Generic;
using System.Linq;
using Cake.Genymotion.Config;

namespace Cake.Genymotion
{
    [CakeAliasCategory("Genymotion")]
    public static class GenymotionAliases
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="deviceIdentifier"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void AdbConnectGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionDeviceSettings settings = null)
        {
            var runner = new GenymotionDeviceRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings ?? new GenymotionDeviceSettings());
            runner.AdbConnect(deviceIdentifier);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="deviceIdentifier"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void AdbDisconnectGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionDeviceSettings settings = null)
        {
            var runner = new GenymotionDeviceRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings ?? new GenymotionDeviceSettings());
            runner.AdbDisconnect(deviceIdentifier);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="deviceIdentifier"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void FactoryResetGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionAdminSettings settings = null)
        {
            var runner = new GenymotionAdminRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings ?? new GenymotionAdminSettings());
            runner.FactoryReset(deviceIdentifier);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        [CakeMethodAlias]
        public static IReadOnlyList<GenymotionAdminListResult> ListGenymotionSimulators(this ICakeContext context, GenymotionAdminSettings settings = null)
        {
            var runner = new GenymotionAdminRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings ?? new GenymotionAdminSettings());
            return runner.List().ToList().AsReadOnly();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="licenseKey"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void RegisterGenymotionLicense(this ICakeContext context, string licenseKey, GenymotionLicenseSettings settings = null)
        {
            var runner = new GenymotionLicenseRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings ?? new GenymotionLicenseSettings());
            runner.Register(licenseKey);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void ResetAllGenymotionSimulators(this ICakeContext context, GenymotionAdminSettings settings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="deviceIdentifier"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void ResetGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionAdminSettings settings = null)
        {
            var runner = new GenymotionAdminRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings ?? new GenymotionAdminSettings());
            runner.Reset(deviceIdentifier);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="deviceIdentifier"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void StartGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionAdminSettings settings = null)
        {
            var runner = new GenymotionAdminRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings ?? new GenymotionAdminSettings());
            runner.Stop(deviceIdentifier);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void StopAllGenymotionSimulators(this ICakeContext context, GenymotionAdminSettings settings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="deviceIdentifier"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void StopGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionAdminSettings settings = null)
        {
            var runner = new GenymotionAdminRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings ?? new GenymotionAdminSettings());
            runner.Stop(deviceIdentifier);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void ConfigureGenymotion(this ICakeContext context, GenymotionConfigSettings settings)
        {
            var runner = new GenymotionConfigRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings);
            runner.Config();
        }
    }
}