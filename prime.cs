using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Is this a prime number?";

            Console.Write("Number: ");
            string r = Console.ReadLine();
            uint n,
                 x = 0;

            if (!uint.TryParse(r, out n))
            {
                Console.WriteLine("Wrong value entered!");
            }
            else
            {
                n = Convert.ToUInt32(r);
                //double s = Math.Floor(Math.Sqrt(n));
                //double s = Math.Round(Math.Sqrt(n), 0, MidpointRounding.AwayFromZero);

                for (uint i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        x++;
                    }

                    if (x > 2)
                    {
                        break;
                    }
                }

                if (x > 2)
                {
                    Console.WriteLine("The " + n + " is not a prime number!");
                }
                else
                {
                    Console.WriteLine("The " + n + " is a prime number!");
                }
            }

            Console.ReadLine();
        }
    }
}
