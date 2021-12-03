using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extensions
{
    public static class Extensions
    {
        public static string RemoveNonAlphanumeric(string text)
        {
            var result = Regex.Replace(text, @"[^A-Za-z0-9]+", " ");
            return result;

        }
    }
}
