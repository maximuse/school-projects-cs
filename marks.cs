using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace marks
{
    class datas
    {
        public string name;
        public byte five,
                    four,
                    three,
                    two,
                    one;
        public double point;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[11];
            List<datas> list = new List<datas>();

            string filename = @"enaplo.txt";
            StreamReader file = new StreamReader(filename, Encoding.Default);

            while (!file.EndOfStream)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = file.ReadLine();
                }
            }
            file.Close();

            foreach (string item in array)
            {
                string[] data = item.Split(' ');

                double a, b, c, d, e;

                a = Convert.ToDouble(data[2]) * 3;
                b = Convert.ToDouble(data[3]) * 2;
                c = Convert.ToDouble(data[5]) * -1;
                d = Convert.ToDouble(data[6]) * -2;
                e = a + b + c + d;

                list.Add(new datas()
                {
                    name = data[0] + " " + data[1],
                    five = Convert.ToByte(data[2]),
                    four = Convert.ToByte(data[3]),
                    three = Convert.ToByte(data[4]),
                    two = Convert.ToByte(data[5]),
                    one = Convert.ToByte(data[6]),
                    point = Convert.ToInt32(e)
                });
            }

            double point = 0;
            string fullpoints = "",
                   aboveAvg = "",
                   maxNames = "";
            int max = 0;

            foreach (var item in list)
            {
                double points = item.point;
                point += points;
                fullpoints += points + ", ";
            }

            Console.WriteLine("3. feladat:\n\tA pontszámok: " + fullpoints);

            double avg = point / list.Count;
            Console.WriteLine("\n\n4. feladat:\n\tA pontszámok átlaga: " + avg);

            foreach (var item in list)
            {
                if (item.point > avg)
                {
                    aboveAvg += item.name + "\tPontszám: " + item.point + "\n\t";
                }

                if (item.point > max)
                {
                    max = Convert.ToInt32(item.point);
                }
            }

            foreach (var item in list)
            {
                if (item.point == max)
                {
                    maxNames += item.name + "\n\t";
                }
            }

            Console.WriteLine("\n\n5. feladat:\n\t" + aboveAvg);
            Console.WriteLine("\n6. feladat:\n\t" + maxNames);

            Console.ReadLine();
        }
    }
}