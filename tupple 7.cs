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
            (int, double) t1 = (17, 3.14);
            (double First, double Second) t2 = (0.0, 1.0);
            t2 = t1;
            Console.WriteLine($"{nameof(t2)}: {t2.First} and {t2.Second}");
        
            (double A, double B) t3 = (2.0, 3.0);
            t3 = t2;
            Console.WriteLine($"{nameof(t3)}: {t3.A} and {t3.B}");
           

            Console.ReadKey();
        }
    }
}
