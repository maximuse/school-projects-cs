using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Föld / Hold (1 / 2): ");
            int p = Convert.ToInt32(Console.ReadLine());
            double t = 0;
            Console.Write("Magasság: ");
            int s = Convert.ToInt32(Console.ReadLine());

            if (p == 1)
            {
                t = Math.Round(Math.Sqrt((2 * s) / 9.81), 3);
            }
            else
            {
                t = Math.Round(Math.Sqrt((2 * s) / (9.81 / 6)), 3);
            }

            Console.WriteLine("Idő: " + t);
            Console.ReadKey();
        }
    }
}