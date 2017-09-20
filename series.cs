using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace series
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "";
            int all = 0,
                even = 0,
                evens = 0,
                odd = 0,
                odds = 0;

            string filename = @"sorozat.txt";
            StreamReader file = new StreamReader(filename, Encoding.Default);
            ArrayList array = new ArrayList();
            while (!file.EndOfStream)
            {
                array.Add(Convert.ToInt32(file.ReadLine()));
            }
            file.Close();

            int c = array.Count;

            foreach (int item in array)
            {
                data += item + ", ";

                all += item;

                if (item % 2 == 0)
                {
                    even++;
                    evens += item;
                }
                else
                {
                    odd++;
                    odds += item;
                }
            }
            data = data.TrimEnd(' ');
            data = data.TrimEnd(',');
            WriteLine(data);

            double allavg = all / c;
            double evensavg = evens / c;
            double oddsavg = odds / c;

            WriteLine("\n\nÖsszes szám: " + c + "\nÖsszes szám összege: " + all + "\nÖsszes szám átlaga: " + allavg + "\n\nPáros szám: " + even + "\nPáros számok összege: " + evens + "\nPáros számok átlaga: " + evensavg + "\n\nPáratlan szám: " + odd + "\nPáratlan számok összege: " + odds + "\nPáratlan számok átlaga: " + oddsavg);

            ReadLine();
        }
    }
}