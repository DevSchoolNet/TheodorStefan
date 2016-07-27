using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3
{
    public static class StringExtension
    {
        public static String RemoveVocals(this String str)
        {
            return str.Replace('a', ' ');
        }
    }
}
