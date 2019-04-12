using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloomWCFService
{
    public static class Extensions
    {
        public static int ParseInt(this string source, int defaultValue)
        {
            int intValue;

            return (int.TryParse(source, out intValue) ? intValue : defaultValue);
        }
    }
}
