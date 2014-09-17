using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Secret
{
	public enum Alphabet { A = 1, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z }

	class Secret
	{
		static void Main ( string[] args )
		{
			BigInteger num = BigInteger.Parse ( Console.ReadLine () );

			if (num < 0)
			{
				num = num * (-1);
			}
			BigInteger numCopy = num;

			int count = 0;

			while (numCopy > 0)
			{
				numCopy = numCopy / 10;
				count++;
			}

			numCopy = num;
			BigInteger[] arr = new BigInteger[count + 1];

			for (int i = 1; i < arr.Length; i++)
			{
				arr[i] = numCopy % 10;
				numCopy = numCopy / 10;
			}

			BigInteger sum = 0;

			for (int i = 1; i < arr.Length; i++)
			{
				BigInteger temp = 0;

				if (i % 2 != 0)
				{
					temp = arr[i] * i * i;
				}

				if (i % 2 == 0)
				{
					temp = arr[i] * arr[i] * i;
				}

				sum = sum + temp;
			}

			Console.WriteLine ( sum );

			BigInteger length = sum % 10;

			if (length == 0)
			{
				Console.WriteLine ( "{0} has no secret alpha-sequence", num );
			}

			BigInteger r = sum % 26;
			r = r + 1;

			for (int i = 1; i <= length; i++)
			{
				Alphabet some = (Alphabet) ((int) r);
				Console.Write ( some );
				r++;
				if (r >= 27)
				{
					for (int j = 1; j <= 15; j++)
					{
						if (r == 27 * j)
						{
							r = 1;
						}
					}
				}
			}

			Console.WriteLine ();
		}
	}
}
