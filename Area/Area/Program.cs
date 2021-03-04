using System;

namespace Area
{
	class Program
	{
		static void Main(string[] args)

		{
			int attempt = 0;
			string userInput;
			double side;
			double min = 0.5;
			double max = 5.0;
			double squareArea;
			double radius;
			double circleArea;
			bool isCorrectSide;
			bool isCorrectRadius;

			do
			{
				Console.Write("Please enter numeric value for a square side and click Enter: ");
				userInput = Console.ReadLine();
				isCorrectSide = Double.TryParse(userInput, out side);

				attempt++;
			}
			while (attempt < 3 && !isCorrectSide);

			if (!isCorrectSide)
			{
				side = GetRandomValue(min, max);
				Console.WriteLine($"{attempt} attempts of your input have failed.");
				Console.WriteLine($"A random value is generated: {side}.");
			}

			Square square = new Square(side);
			squareArea = square.GetArea();

			Console.WriteLine("\nSquare area is: {0:F2}", squareArea);

			attempt = 0;
			do
			{
				Console.Write("\nPlease enter numeric value for a circle radius and click Enter: ");
				userInput = Console.ReadLine();
				isCorrectRadius = Double.TryParse(userInput, out radius);

				attempt++;
			}
			while (attempt < 3 && !isCorrectRadius);

			if (!isCorrectRadius)
			{
				radius = GetRandomValue(min, max);
				Console.WriteLine($"{attempt} attempts of your input have failed.");
				Console.WriteLine($"A random value is generated: {radius}.");
			}

			Circle circle = new Circle(radius);
			circleArea = circle.GetArea();

			Console.WriteLine("\nCircle area is: {0:F2}", circleArea);

			double squaredCircleRadius = SquaredCircle(side);
			double circledSquareRadius = CircledSquare(side);

			if (squaredCircleRadius >= radius)
			{
				Console.WriteLine("\nCircle fits square. It can be inscribed into this square ");
			}
			else
			{
				Console.WriteLine("\nCircle doesn't fit square. It cannot be inscribed into square.");
			}

			if (circledSquareRadius <= radius)
			{
				Console.WriteLine("Square fits circle. It can be inscribed into this circle");
			}
			else
			{
				Console.WriteLine("Square doesn't fit circle. It cannot be inscribed into the circle.");

			}
		}
		static double GetRandomValue(double minimum, double maximum)
		{
			{
				Random random = new Random();
				double randomValue = random.NextDouble() * (maximum - minimum) + minimum;
				return randomValue;
			}
		}
		static double SquaredCircle(double squareSide)
		{
			double rad = squareSide / 2;
			return rad;
		}
		static double CircledSquare(double squareSide)
		{
			double rad = squareSide / Math.Sqrt(2);
			return rad;

		}
	}
}

