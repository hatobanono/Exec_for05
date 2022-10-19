using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <=5; i++)
			{
				string row1 = new string('+', 5 - i);
				Console.Write(row1);

				for (int k = 1; k <= i; k++) 
				{
					Console.Write(i);
				}

				Console.WriteLine();

			}
			
		}
	}
}
