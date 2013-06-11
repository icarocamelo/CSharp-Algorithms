using System;
using System.Collections.Generic;

namespace SumOfSquares
{
	public class SumOfSquares
	{
		public static void Main (string[] args)
		{
			double result = 0;

			List<double> numbers = new List<double>();

			//Generate input
			for (int i = 1; i <= 5 ; i++) {
				double number = i + new Random().Next(100);
				numbers.Add(number);
				Console.WriteLine(i + "o. number: " + number);
				result += Math.Pow(number, 2);
			}
				
			Console.WriteLine("Sum: " + result);
		}
	}
}
