using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FingerprintAuthentication.Commons.Utils
{
    public static class StringUtils
    {
        public static string NumbersOnly(string text)
        {
            Regex regex = new Regex(@"\d");
            return string.Join("", regex.Matches(text).Cast<Match>().Select(m => m.Value).ToArray());
        }
    }
}
