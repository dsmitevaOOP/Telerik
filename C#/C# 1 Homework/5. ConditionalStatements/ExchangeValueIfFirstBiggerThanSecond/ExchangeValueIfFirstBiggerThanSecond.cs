using System;

//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

class ExchangeValueIfFirstBiggerThanSecond
	{
	static void Main()
		{
			Console.Write("Enter the first number: ");
			int first = int.Parse(Console.ReadLine());

			Console.Write("Enter the second number: ");
			int second = int.Parse(Console.ReadLine());

			if (first > second)
				{
					first = first + second;
					second = first - second;
					first = first - second;
					Console.WriteLine("The bigger number is the second one, so the first number now has value {0} and the second number has value {1} !", first, second);
				}

			Console.WriteLine("The second number is bigger!");
		}
	}

