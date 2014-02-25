// Write a program that asks the user for a number n and gives him
// the possibility to choose between computing the sum and computing the product of 1,…,n.


using System;

namespace Elementary6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hey man, give me that sweet sweet integer > 1.");
			Console.WriteLine ("If you choose to disobey me, I'll crash without remorse.");
			int n = Convert.ToInt32 (Console.ReadLine ()); 

			Console.WriteLine ("Okay.. seems you like actually gave me an int.. now choose" +
			" if you want to see the sum or the product by saying 'sum' or 'product'.");
			string ans = Console.ReadLine ();

			if (ans.Equals ("sum")) {
				Console.WriteLine ("The total sum is " + ((n + 1) * (n) / 2));
			} else if (ans.Equals ("product")) {
				uint product = 1;
				for (uint i = 1; i < n; i++) {
					product *= i; 
				}
				Console.WriteLine ("The total product is " + product);
			} else { 
				Console.WriteLine ("You son of a bitch. I'm out.");
			}
		}
	}
}
