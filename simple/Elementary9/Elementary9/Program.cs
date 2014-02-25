// Write a guessing game where the user has to guess a secret number. 
// After every guess the program tells the user whether his number was 
// too large or too small. At the end the number of tries needed should be 
// printed. I counts only as one try if the user inputs the same number consecutively.

using System;

namespace Elementary9
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Random RNG = new Random ();

			int MAX_ATTEMPTS = 6;
			int CurrAttempts = 0;
			int SuperSecretNumber = RNG.Next (150);
			int CurrGuess = -1;

			Console.WriteLine ("You have " + MAX_ATTEMPTS + " guesses to find the secret number 0-150. GL HF");

			while (CurrAttempts < MAX_ATTEMPTS && CurrGuess != SuperSecretNumber) {
				CurrGuess = Convert.ToInt32 (Console.ReadLine ());
				if (CurrGuess < SuperSecretNumber) {
					Console.WriteLine ("Lol, too low mofo");
				} else if (CurrGuess > SuperSecretNumber) {
					Console.WriteLine ("Too high dumbass");
				} else {
					Console.WriteLine ("Fucking nailed it.");
				}
				CurrAttempts++;
			}

			if (CurrGuess == SuperSecretNumber) {
				Console.WriteLine ("OP OP");
			} else {
				Console.WriteLine ("Get rekt");
			}

		}
	}
}
