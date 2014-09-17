using System;
using System.Numerics;

//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

class SumNXSecVar
{
	static void Main ()
	{
		Console.Write ( "Enter N: " );
		int N = int.Parse ( Console.ReadLine () );

		Console.Write ( "Enter X: " );
		int X = int.Parse ( Console.ReadLine () );

		BigInteger fact = 1;
		BigInteger prod = 1;
		decimal sum = 1;

		for (int i = 1; i <= N; i++)
		{
			prod *= i;
			fact *= X;
			decimal res = (decimal) prod / (decimal) fact;
			sum += res;
		}
		Console.WriteLine ( sum );
	}
}

