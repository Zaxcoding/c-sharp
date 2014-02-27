// program to demonstrate how slowly the harmonic series 1/n diverges

using System;

namespace HarmonicSeries
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double sum = 0;
			double one = 1;
			int temp = 1;


			for (double i = 1; ; i++) {
				sum += one / i;
				if ((int)sum == temp) {
					Console.WriteLine ("It took n = " + i + " to get to " + temp);
					temp++;
				}
			
			}

		}
	}
}
