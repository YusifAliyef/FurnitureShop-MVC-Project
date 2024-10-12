using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.CoreLayer.Extentions
{
    public static class ConvertExtentions
    {
        public static string ByteToString(this byte[] byteItem)
        {
            return Convert.ToBase64String(byteItem);
        }
        public static byte[] StringToByte(this string stringItem)
        {
            return Convert.FromBase64String(stringItem);
        }

    }
}
