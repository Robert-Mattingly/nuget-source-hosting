using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumedLibrary
{
    public static class ConsumedExtensions
    {
        public static string PadLength(this string baseString, char padChar, int totalLength)
        {
            var fullPad = Enumerable.Range(0, totalLength - baseString.Length).Select(x => padChar);
            return baseString + new string(fullPad.ToArray());
        }
    }
}
