// Permalink: http://problemotd.com/problem/the-lone-survivor/

using System;

namespace Application
{
	class MainClass
	{
		private static int next;

		public static void Main (string[] args)
		{
			Console.WriteLine ("How many people are seated at the table?");

			int numPeople = Convert.ToInt32(Console.ReadLine ());
			int swordHolder = 0;
			int[] tableOfPeople = new int[numPeople];

			for (int peopleKilled = 0; peopleKilled < numPeople - 1; peopleKilled++) {
				Console.WriteLine ("{0} has the sword", swordHolder + 1);
				swordHolder = killGuyNextTo (tableOfPeople, swordHolder);
			}
		}

		private static int killGuyNextTo(int [] table, int swordHolder) {
			for (next = swordHolder + 1; table [next % table.Length] == -1; next = ++swordHolder + 1)
				;
			table [next % table.Length] = -1;
			return passTheSword (table, next) % table.Length;
		}

		private static int passTheSword(int [] table, int deadGuy) {
			for (next = deadGuy + 1; table [next % table.Length] == -1; next = ++deadGuy + 1);
				;
			return next % table.Length;
		}
	}
}
