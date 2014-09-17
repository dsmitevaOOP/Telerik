using System;

//Write a program that finds the greatest of given 3 variables.

class MaxValue
{
	static void Main ()
	{
		Console.Write ( "Enter first number: " );
		double first = double.Parse ( Console.ReadLine () );

		Console.Write ( "Enter second number: " );
		double second = double.Parse ( Console.ReadLine () );

		Console.Write ( "Enter third number: " );
		double third = double.Parse ( Console.ReadLine () );

		double maxValue = first;

		if (second > maxValue)
		{
			maxValue = second;
		}
		if (third > maxValue)
		{
			maxValue = third;
		}

		Console.WriteLine ("The greatest number is {0}", maxValue);
	}
}
