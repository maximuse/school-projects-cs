using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace series {
	class Program {
		static void Main(string[] args) {
			int even = 0,
				evens = 0,
				odd = 0,
				odds = 0;
			
			StreamReader file = new StreamReader(@"sorozat.txt");
			ArrayList array = new ArrayList();
			while(!file.EndOfStream) {
				array.Add(Convert.ToInt32(file.ReadLine()));
			}
			file.Close();
			
			int c = array.Count;
			
			foreach (int item in array) {
				Write(item + ", ");

				if(item%2==0) {
					even++;
					evens += item;
				}
				else {
					odd++;
					odds += item;
				}
			}
			
			double evensavg = evens / c;
			double oddsavg = odds / c;
			
			WriteLine("\n\nÖsszesen: " + c +  "\n\nPáros: " + even + "\nPáratlan: " + odd + "\n\nPáros számok összege: " + evens + "\nPáratlan számok összege: " + odds + "\n\nPáros számok átlaga: " + evensavg + "\nPáratlan számok átlaga: " + oddsavg);
			
			ReadLine();
		}
	}
}
