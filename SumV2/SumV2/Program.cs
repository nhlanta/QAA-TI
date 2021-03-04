using System;

namespace SumV2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("You need to provide a range of values which accomodates more than 10 digits");
			Console.Write("\nPlease enter a start of a range of natural numbers: ");
			int rangeStart = Convert.ToInt32(Console.ReadLine());
			Console.Write("Please enter an end of a range of natural numbers: ");
			int rangeEnd = Convert.ToInt32(Console.ReadLine());
			
			int length = rangeEnd - rangeStart + 1;
			bool isCount = Convert.ToBoolean(length > 10);
			int[] digitsArray = new int[length];
			int sum = 0;

			if (isCount)
			{
				for (int i = 0; i < digitsArray.Length; i++)
				{
					digitsArray[i] = rangeStart + i;
					int j = digitsArray[i];

					if (j % 3 == 0 && j % 5 != 0)
					{
						sum = sum + j;
					}
				}
				Console.WriteLine("\nSum of digits in your range which can be devided to 3 but cannot be to 5 is: {0}",sum);
			}
			else
			{
				Console.WriteLine("Please enter a bigger range. Should be more than 10 digits in it.");
			}
		}
	}
}
