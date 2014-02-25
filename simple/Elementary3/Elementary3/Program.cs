// Modify the previous program such that only the users Alice and Bob are greeted with their names.

using System;

namespace Elementary3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hey dude, gimme your name.");
			String name = Console.ReadLine ();
			if (name.Equals ("Alice") || name.Equals ("Bob")) {
				Console.WriteLine ("Hey it's you, " + name);
			} else {
				Console.WriteLine ("Nvm, not who I thought you were.");
			}
		}
	}
}
