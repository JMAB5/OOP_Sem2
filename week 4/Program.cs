using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter two numbers:");
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int sum = num1 + num2;
			Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
			Console.ReadLine();

			try
			{
				int value = 0 / int.Parse("<0");
				Console.WriteLine(value);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.ReadLine();
			}
		}
	}
}









