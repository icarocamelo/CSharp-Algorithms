using System;

namespace eDeploySolution
{
	public class MultipleClass
	{
		public static void Main (string[] args)
		{
			for (int i = 0; i < 100; i++) {
				string message = "";

				if (i % 3 == 0){
					message += "BUZZ";
				}

				if (i % 5 == 0){
					message += "BIZZ";
				}

				Console.WriteLine(i + " - " + message);
			}
		}
	}
}
