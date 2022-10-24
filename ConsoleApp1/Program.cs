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
			int rows = 5;
			for (int i = 1; i <= rows; i++) 
			{
				//string row1 = new string('+', 5 - i);
				//Console.Write(row1);

				//for (int k = 1; k <= i; k++)
				//{
				//	Console.Write(i);
				//}

				//Console.WriteLine();

				string plusString = new string('+', rows - i);
				string numbers = new string(i.ToString()[0], i);
				string row = plusString + numbers;
				Console.WriteLine(row);


			}
			
		}
	}
}
