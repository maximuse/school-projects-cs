using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace randnums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Random rand = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(10, 100);
                Console.WriteLine(nums[i]);
            }

            int max = nums.Max();
            int min = nums.Min();
            double val = max - min;

            Console.WriteLine("\n\nA legnagyobb (" + max + ") és a legkissebb (" + min + ") szám közti különbség " + val + ".");

            StreamWriter file = File.AppendText(@"nums.txt");
            file.WriteLine(val);
            file.Close();

            Console.ReadKey();
        }
    }
}