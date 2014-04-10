// Problem description: http://problemotd.com/problem/transposition-cipher/

using System;
using System.IO;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			if (args.Length != 1) {
				Console.WriteLine ("Just so you know, I expect an input file with two lines:\n" +
				"The first has the key\n" +
				"The next has the encrypted text");
				return;
			}

			String key;
			String[] encryptedText;

			// Read in the file, ge the key from line one
			// and the encrypted text from the words delimited by ' '
			using (StreamReader reader = new StreamReader(args[0])) {
				key = reader.ReadLine();
				encryptedText = reader.ReadLine ().Split (' ');
			}

			// 2-d arrays in c#, kinda funky
			char[,] block = new char[encryptedText [0].Length + 1, key.Length];

			// but the key in the first row of the block
			for (int i = 0; i < key.Length; i++) {
				block [0, i] = key [i];
			}

			// sort the key alphabetically
			char[] sorted = key.ToCharArray ();
			Array.Sort (sorted);
		
			// fill in columns based on alphabetical order of key
			for (int j = 0; j < encryptedText.Length; j++) {
				int index = key.IndexOf(sorted[j]);
				for (int i = 0; i < encryptedText[j].Length; i++) {
					block[i+1, index] = encryptedText[j][i];
				}
			}

			// print out the answer
			for (int i = 0; i < block.GetLength(0); i++) {
				for (int j = 0; j < block.GetLength(1); j++) {
					Console.Write (block [i, j] + " ");
				}
				Console.WriteLine ();
			}
		}
	}
}
