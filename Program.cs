using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int x = 5;
            int y = 6;
            int z = 7;
            int result1,result2, result3;
            result1 = Convert.ToInt32(0.5 * ((b * c) + (a * b)) - 3 * ((a * (c * c))));
            result2 = Convert.ToInt32(9* (a * b) - 0.75 * (d * d) * ((3 * y) + a));
            result3 = Convert.ToInt32(3 * (x * y) + (34 * z) - (x * ((3 * y) + (67 * z))));
            Console.WriteLine("If a = 1, b = 2, c = 3, d = 4, x = 5, y = 6, z = 7,");
            Console.WriteLine("1. then evaluation of ½ (bc + ab) – 3ac^2 will give: " + result1);
            Console.WriteLine("2. then evaluation of 9ab – ¾ d^2 (3y + a)  will give: " + result2);
            Console.WriteLine("3. then evaluation of 3xy + 34z – x(3y+67z) will give: " + result3);


        }
    }
}
