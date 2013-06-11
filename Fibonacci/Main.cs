using System;

namespace Fibonacci
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int number = 0;
			long result = 0;

			for (int i = 0; i < 100; i++) {
				result = fibonacci(i);

				if ( (result / 10000) >= 1){
					number = i;
					break;
				}
			}

			Console.WriteLine("Element position: " + number);
			Console.WriteLine("Element value: " + result);
		}

		static long fibonacci(int n) {
        	if (n < 2) {
            	return n;
        	} else {
            	return fibonacci(n - 1) + fibonacci(n - 2);
        	}
    	}



	}
}
