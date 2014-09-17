using System;

//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum.

class SumNumbers
	{
	static void Main()
		{
			Console.Write("Enter the number of the numbers you want to sum: ");
			int count = int.Parse(Console.ReadLine());
			double sum = 0;
			for (int i = 0; i < count; i++)
			{
				Console.Write("Enter number: ");
				double num = double.Parse(Console.ReadLine());
				sum = sum + num;
			}
			Console.WriteLine("The sum of the numbers is {0}", sum);

			//Console.WriteLine("Press Enter: ");
			//ConsoleKeyInfo cki = Console.ReadKey();
			//double num;
			//double sum = 0;
			//if (cki.Key == ConsoleKey.Enter)
			//	{
			//	while (cki.Key == ConsoleKey.Enter)
			//		{
			//			Console.WriteLine("Enter number: ");
			//			num = double.Parse(Console.ReadLine());
			//			sum = sum + num;
			//			Console.WriteLine(sum);
			//		}
			//	}
		}	
	}

