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
            Console.WriteLine("|     x       |      y       |");
            for (double x = 1; x <= 29; x += 0.2) ;
            {
                double x = double.Parse(Console.ReadLine());
                double y = Math.Pow(Math.Log(x), 2) - x + 4;
                Console.WriteLine("|{0,13:F1}|{1,14:F2}|", x, y);


            }
        }

    }
}
