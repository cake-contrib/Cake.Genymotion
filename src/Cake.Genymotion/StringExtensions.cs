using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake.Genymotion
{
    public static class StringExtensions
    {
        public static string ToStringOnOff(this bool boolean)
        {
            return boolean ? "on" : "off";
        }
    }
}
