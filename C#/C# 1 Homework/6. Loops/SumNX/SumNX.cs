using System;
using System.Numerics;

//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

class SumNX
{
	static void Main ()
	{
		Console.Write ( "Enter N: " );
		int N = int.Parse ( Console.ReadLine () );

		Console.Write ( "Enter X: " );
		int X = int.Parse ( Console.ReadLine () );

		BigInteger[] factorial = new BigInteger[N];
		for (int j = 1; j <= factorial.Length; j++)
		{
			BigInteger fact = 1;
			for (int i = 1; i <= j; i++)
			{
				fact *= i;
			}
			factorial[j - 1] = fact;
		}

		int[] product = new int[N];
		for (int j = 1; j <= product.Length; j++)
		{
			int prod = 1;
			for (int i = 1; i <= j; i++)
			{
				prod *= X;
			}
			product[j - 1] = prod;
		}

		decimal sum = 1;
		for (int i = 0; i < N; i++)
		{
			sum = sum + ((decimal) factorial[i] / product[i]);
		}
		Console.WriteLine ( "Your sum is {0}", sum );
	}
}

