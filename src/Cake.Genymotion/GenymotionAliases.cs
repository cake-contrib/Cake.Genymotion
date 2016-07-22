using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.Tooling;
using Cake.Genymotion;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cake.Genymotion.Admin;
using Cake.Genymotion.Config;
using Cake.Genymotion.Device;
using Cake.Genymotion.License;

namespace Cake.Genymotion
{
    [CakeAliasCategory("Genymotion")]
    [CakeNamespaceImport("Cake.Genymotion")]
    [CakeNamespaceImport("Cake.Genymotion.Admin")]
    [CakeNamespaceImport("Cake.Genymotion.Config")]
    [CakeNamespaceImport("Cake.Genymotion.Device")]
    [CakeNamespaceImport("Cake.Genymotion.License")]
    [CakeNamespaceImport("Cake.Genymotion.Version")]
    public static class GenymotionAliases
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        /// <param name="deviceIdentifier"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void AdbConnectGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionDeviceSettings settings)
        {
            var runner = new GenymotionDeviceRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings);
            runner.AdbConnect(deviceIdentifier);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        /// <param name="deviceIdentifier"></param>
        [CakeMethodAlias]
        public static void AdbConnectGenymotionSimulator(this ICakeContext context, string deviceIdentifier)
        {
            AdbConnectGenymotionSimulator(context, deviceIdentifier, new GenymotionDeviceSettings());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        /// <param name="deviceIdentifier"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void AdbDisconnectGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionDeviceSettings settings)
        {
            var runner = new GenymotionDeviceRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings);
            runner.AdbDisconnect(deviceIdentifier);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        /// <param name="deviceIdentifier"></param>
        [CakeMethodAlias]
        public static void AdbDisconnectGenymotionSimulator(this ICakeContext context, string deviceIdentifier)
        {
            AdbDisconnectGenymotionSimulator(context, deviceIdentifier, new GenymotionDeviceSettings());
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

        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        /// <param name="deviceIdentifier"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void FactoryResetGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionAdminSettings settings)
        {
            var runner = new GenymotionAdminRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings);
            runner.FactoryReset(deviceIdentifier);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        /// <param name="deviceIdentifier"></param>
        [CakeMethodAlias]
        public static void FactoryResetGenymotionSimulator(this ICakeContext context, string deviceIdentifier
            )
        {
            FactoryResetGenymotionSimulator(context, deviceIdentifier, new GenymotionAdminSettings());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        [CakeMethodAlias]
        public static IReadOnlyList<GenymotionSimulator> ListGenymotionSimulators(this ICakeContext context, GenymotionAdminSettings settings)
        {
            var runner = new GenymotionAdminRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings);
            return runner.List().ToList().AsReadOnly();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        [CakeMethodAlias]
        public static IReadOnlyList<GenymotionSimulator> ListGenymotionSimulators(this ICakeContext context)
        {
            return ListGenymotionSimulators(context, new GenymotionAdminSettings());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        /// <param name="licenseKey"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void RegisterGenymotionLicense(this ICakeContext context, string licenseKey, GenymotionLicenseSettings settings)
        {
            var runner = new GenymotionLicenseRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings);
            runner.Register(licenseKey);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        /// <param name="licenseKey"></param>
        [CakeMethodAlias]
        public static void RegisterGenymotionLicense(this ICakeContext context, string licenseKey)

        {
            RegisterGenymotionLicense(context, licenseKey, new GenymotionLicenseSettings());
        }

        /// <summary>
        /// Not implemented yet. Send in a pull-request!
        /// </summary>
        /// <param name="context"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void ResetAllGenymotionSimulators(this ICakeContext context, GenymotionAdminSettings settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Not implemented yet. Send in a pull-request!
        /// </summary>
        /// <param name="context"></param>
        public static void ResetAllGenymotionSimulators(this ICakeContext context)
        {
            ResetAllGenymotionSimulators(context, new GenymotionAdminSettings());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        /// <param name="deviceIdentifier"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void StartGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionAdminSettings settings)
        {
            var runner = new GenymotionAdminRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings);
            runner.Start(deviceIdentifier);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        /// <param name="deviceIdentifier"></param>
        [CakeMethodAlias]
        public static void StartGenymotionSimulator(this ICakeContext context, string deviceIdentifier)
        {
            StartGenymotionSimulator(context, deviceIdentifier, new GenymotionAdminSettings());
        }

        /// <summary>
        /// Not implemented yet. Send in a pull-request!
        /// </summary>
        /// <param name="context"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void StopAllGenymotionSimulators(this ICakeContext context, GenymotionAdminSettings settings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Not implemented yet. Send in a pull-request!
        /// </summary>
        /// <param name="context"></param>
        [CakeMethodAlias]
        public static void StopAllGenymotionSimulators(this ICakeContext context)
        {
            StopAllGenymotionSimulators(context, new GenymotionAdminSettings());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        /// <param name="deviceIdentifier"></param>
        /// <param name="settings"></param>
        [CakeMethodAlias]
        public static void StopGenymotionSimulator(this ICakeContext context, string deviceIdentifier, GenymotionAdminSettings settings)
        {
            var runner = new GenymotionAdminRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, settings);
            runner.Stop(deviceIdentifier);
        }

        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        /// <param name="deviceIdentifier"></param>
        [CakeMethodAlias]
        public static void StopGenymotionSimulator(this ICakeContext context, string deviceIdentifier)
        {
            StopGenymotionSimulator(context, deviceIdentifier, new GenymotionAdminSettings());
        }
    }
}