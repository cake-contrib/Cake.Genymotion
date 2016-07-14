using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.Genymotion
{
    [CakeAliasCategory("Genymotion")]
    public static class GenymotionAliases
    {
        [CakeMethodAlias]
        public static void AdbConnectGenymotionSimulator(this ICakeContext context, string uuid,
            GenymotionSettings settings)
        {
            throw new NotImplementedException();
        }

        [CakeMethodAlias]
        public static void AdbDisconnectGenymotionSimulator(this ICakeContext context, string uuid,
            GenymotionSettings settings)
        {
            throw new NotImplementedException();
        }

        [CakeMethodAlias]
        public static void ListGenymotionSimulators(this ICakeContext context, GenymotionSettings settings)
        {
            throw new NotImplementedException();
        }

        [CakeMethodAlias]
        public static void RegisterGenymotionLicense(this ICakeContext context, string licenseKey,
            GenymotionSettings settings)
        {
            throw new NotImplementedException();
        }

        [CakeMethodAlias]
        public static void ResetAllGenymotionSimulators(this ICakeContext context, GenymotionSettings settings)
        {
            throw new NotImplementedException();
        }

        [CakeMethodAlias]
        public static void ResetGenymotionSimulator(this ICakeContext context, string uuid, GenymotionSettings settings)
        {
            throw new NotImplementedException();
        }

        [CakeMethodAlias]
        public static void StartGenymotionSimulator(this ICakeContext context, string uuid, GenymotionSettings settings)
        {
            throw new NotImplementedException();
        }

        [CakeMethodAlias]
        public static void StopAllGenymotionSimulators(this ICakeContext context, GenymotionSettings settings)
        {
            throw new NotImplementedException();
        }

        [CakeMethodAlias]
        public static void StopGenymotionSimulator(this ICakeContext context, string uuid, GenymotionSettings settings)
        {
            throw new NotImplementedException();
        }
    }
}