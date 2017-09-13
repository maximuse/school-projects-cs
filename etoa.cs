using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Szöveg: ");
            int c = 0;
            char[] a = {
                'a',
                'á',
                'e',
                'é',
                'i',
                'í',
                'o',
                'ó',
                'ö',
                'ő',
                'u',
                'ú',
                'ü',
                'ű'
            };
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (a.Contains(s[i]))
                {
                    c++;
                }
            }
            s = s.Replace("e", "a");
            Console.WriteLine("A szövegben " + c + "db magánhangzó van.");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
