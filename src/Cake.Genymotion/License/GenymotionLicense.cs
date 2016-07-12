using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake.Genymotion.License
{
    public sealed class GenymotionLicense
    {
        public GenymotionLicenseType LicenseType { get; set; }
        public int ActivatedWorkstations { get; set; }
        public bool LicenseServer { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}
