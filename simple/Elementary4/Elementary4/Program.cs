// Write a program that asks the user for a number n and prints the sum of the numbers 1 to n

using System;

namespace Elementary4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int TheirNum = -1;
			while (TheirNum <= 1) {
				Console.WriteLine ("Hello, I'd like an integer > 1 please.");
				try {
					TheirNum = Convert.ToInt32 (Console.ReadLine ());
				} catch (FormatException ex) {
					Console.WriteLine ("T_T I said integer");
				}
				catch (Exception e) {
					Console.WriteLine ("ty steve");
				}
			}
			Console.Write ("\n\n1");
			for (int i = 2; i <= TheirNum; i++) {
				Console.Write (" + " + i);
			}
			Console.WriteLine (" = " + (TheirNum + 1) * (TheirNum) / 2);
		}
	}
}
