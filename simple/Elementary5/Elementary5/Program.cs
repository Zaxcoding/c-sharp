// Modify the previous program such that only multiples of three or five are considered in the sum, e.g. 3, 5, 6, 9, 10, 12, 15 for n=17

using System;

namespace Elementary5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int TheirNum = -1;
			int sum = 3;
			while (TheirNum <= 1) {
				Console.WriteLine ("Hello, I'd like an integer > 3 please.");
				try {
					TheirNum = Convert.ToInt32 (Console.ReadLine ());
				} catch (FormatException ex) {
					Console.WriteLine ("T_T I said integer");
				}
				catch (Exception e) {
					Console.WriteLine ("ty steve");
				}
			}
			Console.Write ("\n\n3");
			for (int i = 5; i <= TheirNum; i++) {
				if (i % 3 == 0 || i % 5 == 0) {
					Console.Write (" + " + i);
					sum += i;
				}
			}
			Console.WriteLine (" = " + sum);
		}
	}
}
