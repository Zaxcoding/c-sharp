// Write a program that prints a multiplication table for numbers up to 12.

using System;

namespace Elementary7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int i = 1; i <= 12; i++) {
				for (int j = 1; j <= 12; j++) {
					string ToWrite = string.Format ("\t{0}".PadLeft (8), i * j);
					Console.Write (ToWrite);
				}
				Console.WriteLine ();
			}
		}
	}
}
