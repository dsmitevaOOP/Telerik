using System;

class MaxValueFive
{
	static void Main ()
	{
		Console.Write ( "Enter first number: " );
		double first = double.Parse ( Console.ReadLine () );

		Console.Write ( "Enter second number: " );
		double second = double.Parse ( Console.ReadLine () );

		Console.Write ( "Enter third number: " );
		double third = double.Parse ( Console.ReadLine () );

		Console.Write ( "Enter fourth number: " );
		double fourth = double.Parse ( Console.ReadLine () );

		Console.Write ( "Enter fifth number: " );
		double fifth = double.Parse ( Console.ReadLine () );

		double maxValue = first;

		if (second > maxValue)
		{
			maxValue = second;
		}
		if (third > maxValue)
		{
			maxValue = third;
		}

		if (fourth > maxValue)
		{
			maxValue = fourth;
		}

		if (fifth > maxValue)
		{
			maxValue = fifth;
		}

		Console.WriteLine ( "The greatest number is {0}", maxValue );
	}
}
