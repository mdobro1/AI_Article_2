using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailChecker
{
    public static class StringExtensions
    {
        public static string Include(this String str, params object[] values)
        {
            if (!str.IsNullOrEmptyOrWhitespace())
                return string.Format(str, values);
            else
                return str;
        }

        public static bool IsNullOrEmptyOrWhitespace(this String str)
        {
            return String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str);
        }
    }
}
