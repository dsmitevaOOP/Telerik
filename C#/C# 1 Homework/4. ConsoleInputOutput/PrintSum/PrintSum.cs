
using System;

//Write a program that reads 3 integer numbers from the console and prints their sum.

class PrintSum
	{
	static void Main()
		{
			Console.Write("Enter the first number: ");
			double first = double.Parse(Console.ReadLine());
			Console.Write("Enter the second integer: ");
			double sec = double.Parse(Console.ReadLine());
			Console.Write("Enter the third integer: ");
			double third = double.Parse(Console.ReadLine());
			Console.WriteLine(first + sec + third);;
		}
	}

