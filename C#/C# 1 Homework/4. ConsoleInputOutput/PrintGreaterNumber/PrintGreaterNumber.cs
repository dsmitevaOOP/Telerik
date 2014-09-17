using System;

//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

class PrintGreaterNumber
	{
	static void Main()
		{
			Console.Write("Enter the first integer: ");
			int first = int.Parse(Console.ReadLine());
			Console.Write("Enter the second integer: ");
			int sec = int.Parse(Console.ReadLine());
			int res = Math.Max(first, sec);
			Console.WriteLine("The greater number is {0}.", res);
		}
	}

