using System;

//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

class Program
	{
	static void Main()
		{
			float sum1 = 0;
			float sum2 = 0;
			for (int i = 2; i <= 1000; i++)
				{
				if (i % 2 != 0)
					{
						sum1 = sum1 - (1f / i);
					}
				else
					{
						sum2 = sum2 + (1f / i);
					}
				}	
			float sum = 1 + sum1 + sum2;
			Console.WriteLine("The sum is {0:0.000}", sum);
		}
	}

