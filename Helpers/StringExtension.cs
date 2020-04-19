using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP.NET.Helpers
{
    /// <summary>
    /// We extend the string object with the new method Random() using the syntax "this string"
    /// </summary>
    public static class StringExtension
    {
        public static string Random(this string s, int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();

            char ch;
            for (int i = 0; i < size; i++) {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
    }
}
