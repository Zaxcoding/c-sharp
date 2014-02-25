//Write a program that asks the user for his name and greets him with his name.

using System;

namespace Elementary2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hey dude, what's your name?");
			String name = Console.ReadLine ();
			Console.WriteLine ("Sweet, nice to meet you " + name);
		}
	}
}
