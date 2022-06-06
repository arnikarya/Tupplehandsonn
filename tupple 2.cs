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
            var sum = 4.5;
            var count = 3;
            var t = (sum, count);
            Console.WriteLine($"Sum of {t.count} elements is {t.sum}.");
            Console.ReadKey();
        }
    }
}
