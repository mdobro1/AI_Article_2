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
            if (!str.IsNullIfEmptyOrWhitespace())
                return string.Format(str, values);
            else
                return str;
        }

        public static bool IsNullIfEmptyOrWhitespace(this String str)
        {
            return String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str);
        }
    }
}
