using System;

namespace Cake.Genymotion.License
{
    public sealed class GenymotionLicense
    {
        public int ActivatedWorkstations { get; set; }
        public DateTime ExpiresOn { get; set; }
        public bool LicenseServer { get; set; }
        public GenymotionLicenseType LicenseType { get; set; }
    }
}