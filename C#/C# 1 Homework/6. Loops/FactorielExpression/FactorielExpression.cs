using System;
using System.Numerics;

class FactorielExpression
{
	static void Main ()
	{
		Console.WriteLine ( "1 < N < K" );

		Console.Write ( "Enter N: " );
		int N = int.Parse ( Console.ReadLine () );

		Console.Write ( "Enter K: " );
		int K = int.Parse ( Console.ReadLine () );

		double factK = 1;
		for (int i = 1; i <= K; i++)
		{
			factK *= i;
		}

		double factN = 1;
		for (int i = 1; i <= N; i++)
		{
			factN *= i;
		}

		double factKN = 1;
		for (int i = 1; i <= (N - K); i++)
		{
			factKN *= i;
		}

		double result = factK * factKN;
		result = factN / result;

		Console.WriteLine ( "N! / K! * (K - N)! (1 < N < K) is: {0}", result );
	}

}
