using System;
using System.Collections.Generic;

namespace FunctionAccumulate
{
	class MainClass
	{
		public Func<long> acumular (Func<long> combiner, long nullValue, List<int> list)
		{
			if (list.Count == 0) {
				return null;
			}

			var primeiro = list[0];
			list.RemoveAt(0);

			return combiner(primeiro, acumular (combiner, nullValue, list));
		}

		public long combiner(int primeiro, Func<Func<long>, long, List<int>> acumular, Func<long>)
		{
			long value = 0;
			return value;
		}

		public static void Main (string[] args)
		{
			double result = 0;
			List<double> numbers = new List<double>();

			//Generate input
			for (int i = 1; i <= 5 ; i++) {
				double number = i + new Random().Next(100);
				numbers.Add(number);
			}

//			long val = combiner(10, acumular(combiner, 0, numbers));
		}

//		public long 
//			combiner(Func<long> function, long nullValue, List<int> list)
//		{
//
//			if (list.Count == 0) {
//				return nullValue;
//			}
//			var primeiro = list[0];
//			list.RemoveAt(0);
//			return combiner(primeiro, acumular (combiner, nullValue, list));
//		}
	}
}
