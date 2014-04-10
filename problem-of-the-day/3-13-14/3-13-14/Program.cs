/*
 No Divide
 No this isn't a reference to that Linkin Park song. Today's your Introduction to Computer Science mid-term. You're doing alright on the test and the last question is "implement a function that takes in 2 integers and returns the division of the 2 numbers rounded to the nearest integer".
 Piece of cake you say. As you're typing it up you exclaim "what the heck", which gets you some really weird stares. You've just learned that your "/" key is broken. Some of you that are having a really bad day learn that your "/", "*", "+", and "-" are all broken. How can we solve this problem without using any of your broken keys? Note: You're using a pirated version of Windows 2015 so your copy and paste functionality is also broken.
 */

using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			if (args.Length != 2) {
				Console.WriteLine ("Hey man, I need 2 args.");
			}

			int numerator = Convert.ToInt32 (args [0]);
			int denominator = Convert.ToInt32 (args [1]);

			int quotient, remainder, ans;
			quotient = Math.DivRem (numerator, denominator, out remainder);
			if ((remainder << 1) > denominator) {
				ans = Convert.ToInt32 (Math.Round(Convert.ToDouble(String.Concat (quotient.ToString (), ".9"))));
			} else {
				ans = quotient;
			}

			Console.WriteLine ("Answer: {0}", ans);
				
		}
	}
}
