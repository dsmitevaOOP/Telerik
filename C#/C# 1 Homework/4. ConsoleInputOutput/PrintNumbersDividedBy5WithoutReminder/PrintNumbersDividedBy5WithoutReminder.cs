using System;

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

class PrintNumbersDividedBy5WithoutReminder
	{
	static void Main()
		{
			Console.Write("Enter the first integer: ");
			int first = int.Parse(Console.ReadLine());
			Console.Write("Enter the second integer: ");
			int sec = int.Parse(Console.ReadLine());
			if (sec < first)
			{
				first = first + sec;
				sec = first - sec;
				first = first - sec;
			}
			int count = 0;
			for (int i = first; i <= sec; i++)
				{
					if (i % 5 == 0)
					{
						count++;
						Console.WriteLine(i);
					}
				}
			Console.WriteLine(count);
		}
	}

