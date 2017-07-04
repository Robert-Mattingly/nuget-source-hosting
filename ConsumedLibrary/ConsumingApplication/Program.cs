using ConsumedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringsToPad = new string[]
            {
                "Carthage", "Rome", "Istanbul"
            };

            foreach (var @string in stringsToPad)
                Console.WriteLine(@string.PadLength('*', 20));
        }
    }
}
