using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var t = (a, b: 2, 3);
            Console.WriteLine($"The 1st element is {t.Item1} (same as {t.a}).");
            Console.WriteLine($"The 2nd element is {t.Item2} (same as {t.b}).");
            Console.WriteLine($"The 3rd element is {t.Item3}.");
           
            Console.ReadKey();
        }
    }
}
