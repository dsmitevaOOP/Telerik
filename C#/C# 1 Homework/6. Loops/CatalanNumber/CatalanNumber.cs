using System;
using System.Numerics;

//Write a program to calculate the Nth Catalan number by given N.

class CatalanNumber
{
	static void Main ()
	{
		Console.Write ("Enter N: ");
		int N = int.Parse(Console.ReadLine ());

		BigInteger factN = 1;
		for (int i = 1; i <= N; i++)
		{
			factN *= i;
		}

		BigInteger fact2N = 1;
		int lim2N = 2 * N;
		for (int i = 1; i <= lim2N; i++)
		{
			fact2N *= i;
		}

		BigInteger factNPlus1 = 1;
		int limNPlus1 = N + 1;
		for (int i = 1; i <= limNPlus1; i++)
		{
			factNPlus1 *= i;
		}

		decimal res = (decimal)factNPlus1 * (decimal) factN;
		res =  (decimal) fact2N / res;
		Console.WriteLine ("Yout Catalan number is {0}", res);
	}
}
