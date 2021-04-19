using System;
using System.Linq;

namespace PalindromV
{
	class Program
	{
		static void Main(string[] args)
		{
			int attempt = 0;
			string input;

			do
			{
				Console.WriteLine("Please enter some word");
				input = Console.ReadLine().ToLower();

				attempt++;
			}
			while (attempt < 3 && (string.IsNullOrEmpty(input) || input.Any(char.IsDigit)));

			if (string.IsNullOrEmpty(input) || input.Any(char.IsDigit))
			{
				Console.WriteLine("Worse things happen..");
				Console.WriteLine("Don't worry.");
				Console.WriteLine("Next time will be better :)");
			}

			else
			{
				Console.WriteLine("This is " + (IsPalindrome(input) ? "palindrome" : "not palindrome"));
			}

			Console.ReadLine();
		}

		static bool IsPalindrome(string userInput)
		{
			char[] charArray = userInput.ToCharArray();

			for (int i = 0; i < charArray.Length / 2; i++)
			{
				if (charArray[i] != charArray[charArray.Length - 1 - i])
				{
					return false;
				}
			}

			return true;
		}
	}
}
