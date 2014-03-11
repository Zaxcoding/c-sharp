/* Palindromic Numbers
A palindromic number is a number that reads the same forwards as it does backwards. 123321 is a palindromic number where as 321321 is not. Negative numbers may be considered palindromic or not; it's up to you until someone proves otherwise.

Your mission, should you choose to accept it, is to create a program to return whether a number is a palindromic number or not. To make things slightly more interesting you may not use a string or array in your solution. Thus doing something like "123.toString()" is not allowed.

Good luck!
*/

using System;

namespace Application
{

	class MainClass
	{
		static int NUMBER_TO_CHECK = -1245421;

		public static void Main (string[] args)
		{
			Console.WriteLine("Our answer is: {0}", IsPalindrome(NUMBER_TO_CHECK)) ;
		}

		static Boolean IsPalindrome(int num) {

			// this allows us to say negative numbers can be palindromes
			String includeNegative = "";
			if (num < 0) {
				includeNegative = "-";
				num *= -1;
			}

			// get the number of digits in the number
			int digits = (int)Math.Log10 (num) + 1;
			Console.WriteLine ("The number of digits of {0}{1} is {2}", includeNegative, num, digits);

			// then go through half the number
			for (int i = 1; i <= (digits + 1)/2 ; i++) {

				// grab the left digit we're on and the right digit
				int firstDigit = (int)(num / Math.Pow (10, digits - i));
				int secondDigit = (int)(num % Math.Pow(10, i));

				// use this to trim off the rest of the number
				firstDigit %= 10;
				secondDigit /= (int)Math.Pow (10, i-1);

				Console.WriteLine ("{0} == {1}? {2}", firstDigit, secondDigit, firstDigit==secondDigit);

				// this means it's all over and we failed
				if (firstDigit != secondDigit) {
					return false;
				}
			}
			return true;
		}
	}
}
