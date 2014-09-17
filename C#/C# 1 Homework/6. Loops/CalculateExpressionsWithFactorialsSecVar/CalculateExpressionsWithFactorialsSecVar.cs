using System;
using System.Numerics;

//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

//Проверки !!!

class CalculateExpressionsWithFactorialsSecVar
{
	static void Main ()
	{
		Console.WriteLine ( "1 < N < K" );
		Console.Write ( "Enter K: " );
		int K = int.Parse ( Console.ReadLine () );

		Console.Write ( "Enter N: " );
		int N = int.Parse ( Console.ReadLine () );

		BigInteger factN = 1;
		for (int i = 1; i <= N; i++)
		{
			factN *= i;
		}

		BigInteger sum = 1;
		for (int i = K; i >= (K - N + 1); i--)
		{
			sum *= i;
		}

		BigInteger res = factN * sum;
		Console.WriteLine ( "(N! * K!) / (K - N)! (1 < N < K) is: {0}", res );
	}
}

