// Problem description: http://www.problemotd.com/problem/pyramid-sort/ 

using System;

namespace Application
{
	class MainClass
	{
		static int RANDOM_NUMS = 25;

		public static void Main (string[] args)
		{
			Console.WriteLine ("Generating {0} random numbers:", RANDOM_NUMS);
			Random rng = new Random ();

			int[] randoms = new int[RANDOM_NUMS];
			int[] final = new int[RANDOM_NUMS];

			for (int i = 0; i < RANDOM_NUMS; i++) {
				randoms[i] = rng.Next (100);
			}
			Array.Sort (randoms);

			Console.WriteLine ("After sorting the numbers are:");

			for (int i = 0; i < RANDOM_NUMS; i++) {
				Console.Write (randoms [i] + "\t");
			}


			Console.WriteLine ("\nPretty picture incoming:\n");

			for (int i = 0; i < RANDOM_NUMS; i++) {
				string spacing = "";

				if (i % 2 == 0) {
					final [i/2] = randoms [i];
					for (int j = 0; j < i/2; j++) {
						spacing += "  ";
					}
					Console.Write ("{0}{1}", spacing, randoms [i]);
				} else {
					final [RANDOM_NUMS - (i+1)/2] = randoms [i];
					for (int j = 0; j < RANDOM_NUMS - i; j++) {
						spacing += "  ";
					}
					Console.WriteLine ("{0}{1}", spacing, randoms [i]);
				}
			}
		}
	}
}
