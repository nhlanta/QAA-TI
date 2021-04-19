using System;

namespace PalindromV
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a single word");
			string input = Console.ReadLine();
			string userInput = input.ToLower();

			while (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("Please enter some word");
				input = Console.ReadLine();
			}

			Console.WriteLine("This is " + (IsPalindrome(userInput) == true ? "palindrome" : "not palindrome"));
			Console.ReadLine();
		}
		static bool IsPalindrome(string userInput)
		{
			char[] charArray = userInput.ToCharArray();

			for (int i = 0; i < charArray.Length / 2; i++)
				if (charArray[i] != charArray[charArray.Length - 1 - i])
				{
					return false;
				}
			return true;
		}
	}
}
