using System;
using System.Numerics;
//Write a program that calculates N!/K! for given N and K (1<K<N).

class NFactorialDividedByKFactorial
{
	static void Main ()
	{
		Console.WriteLine ("1 < K < N");
		Console.Write ("Enter N: ");
		int N = int.Parse ( Console.ReadLine () );

		Console.Write ("Enter K: ");
		int K = int.Parse(Console.ReadLine ());

		BigInteger factN = 1;
		for (int i = 1; i <= N; i++)
		{
			factN *= i;
		}

		BigInteger factK = 1;
		for (int i = 1; i <= K; i++)
		{
			factK *= i;
		}

		BigInteger result = factN / factK;
		Console.WriteLine ("N! / K! (1 < K < N) is: {0}", result);
	}
}