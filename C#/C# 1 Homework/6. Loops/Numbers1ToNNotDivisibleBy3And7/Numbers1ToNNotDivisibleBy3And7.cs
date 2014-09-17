using System;

//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

class Numbers1ToNNotDivisibleBy3And7
{
	static void Main ()
	{
		Console.Write ( "Enter some number: " );
		int num = int.Parse ( Console.ReadLine () );

		if (num < 0)
		{
			while (num < 0)
			{
				Console.WriteLine ( "Invalid input!" );
				Console.Write ( "Enter some number: " );
				num = int.Parse ( Console.ReadLine () );
			}
		}

		for (int i = 1; i <= num; i++)
		{
			if ((i % 3 != 0) && (i % 7 != 0))
			{
				Console.Write ( i + " " );
			}
		}
		Console.WriteLine ();
	}
}

