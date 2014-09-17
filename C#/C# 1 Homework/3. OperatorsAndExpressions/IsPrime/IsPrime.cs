using System;

//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

class IsPrime
	{
	static void Main()
		{
			Console.WriteLine("The program checks if given positive integer is prime.");
			int myInt = int.Parse(Console.ReadLine());
			bool prime = false;
			int count = 0;
			if (myInt > 1)
			{
				if (myInt > 9)
				{
					for (int i = 2; i <= 9; i++)
					{
						prime = myInt % i != 0 ? true : false;
						if (prime == false)
						{
							count++;
						}
					}
					prime = count != 0 ? false : true;
					Console.WriteLine ( "Is the integer prime? {0}", prime );
				}
				else
				{
					prime = (myInt == 4 || myInt == 6 || myInt == 8 || myInt == 9) ? false : true;
					Console.WriteLine ( "Is the integer prime? {0}", prime );
				}
			}
			else
			{
				prime = false;
				Console.WriteLine ( "Is the integer prime? {0}", prime );
			}
		}
	}
