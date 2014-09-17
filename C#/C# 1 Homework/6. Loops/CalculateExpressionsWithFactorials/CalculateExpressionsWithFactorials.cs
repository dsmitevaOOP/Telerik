using System;
using System.Numerics;

//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

class CalculateExpressionsWithFactorials
{
	static void Main ()
	{
		Console.WriteLine ( "1 < N < K" );
		Console.Write ( "Enter K: " );
		int K = int.Parse ( Console.ReadLine () );

		Console.Write ( "Enter N: " );
		int N = int.Parse ( Console.ReadLine () );

		BigInteger factK = 1;
		for (int i = 1; i <= K; i++)
		{
			factK *= i;
		}

		BigInteger factN = 1;
		for (int i = 1; i <= N; i++)
		{
			factN *= i;
		}

		BigInteger factKN = 1;
		for (int i = 1; i <= (K - N); i++)
		{
			factKN *= i;
		}

		BigInteger result = factK * factN;
		result = result / factKN;

		Console.WriteLine ( "(N! * K!) / (K - N)! (1 < N < K) is: {0}", result );
	}
}

