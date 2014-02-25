// Write a program that prints all prime numbers. 
// (Note: if your programming language does not support arbitrary size numbers, 
// printing all primes up to the largest number you can represent is fine too.)

using System;

namespace Elementary8
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int MAX_PRIME = 0;

			if (args.Length != 1) {
				Console.WriteLine ("Hey man, give me an integer saying the max number you want to consider for a prime.");
				return;
			}

			try {
				MAX_PRIME = Convert.ToInt32(args[0]);
			} catch (Exception ex) {
				Console.WriteLine ("Dude, that's not even an int. Get out.");
				return;
			}

			if (MAX_PRIME < 0) {
				Console.WriteLine ("Really.. this is not even positive. I hate you. I'm done.");
				return;
			}


			Console.WriteLine ("So I'm gonna print all the primes less than " + MAX_PRIME);

			DateTime start = DateTime.Now;

			int[] BigList = new int[MAX_PRIME];
			for (int i = 2; i < MAX_PRIME; i++) {
				if (BigList [i] == 0) {
					for (int j = 2; i * j < MAX_PRIME; j++) {
						BigList [i * j]++;	
					}
				}
			}

			DateTime finish = DateTime.Now;
			TimeSpan diff = finish.Subtract (start);

			for (int i = 2; i < MAX_PRIME; i++) {
				if (BigList [i] == 0) {
					Console.Write (i + ", ");
				}
			}

			Console.WriteLine ("\nBtw, it took " + diff.ToString () + " to compute those primes.");

		}
	}
}
