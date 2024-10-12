using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.CoreLayer.Helper
{
    public static class GeneratorHelper
    {
        private static readonly Random _random=new Random();
        public static int GeneratorConfirmCode(int minlength=6, int maxlength = 6)
        {
            if(minlength<1 || maxlength < minlength)
            {
                throw new ArgumentException("Invalid Length Parametrs.");
            }
            int min = (int)Math.Pow(10, maxlength - 1);
            int max= (int)Math.Pow(10,maxlength) - 1;
            return _random.Next(min,max);
        }
    }
}
