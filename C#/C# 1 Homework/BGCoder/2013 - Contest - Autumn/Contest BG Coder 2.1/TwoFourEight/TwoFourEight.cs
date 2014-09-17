using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TwoFourEight
{
	class TwoFourEight
	{
		static void Main ( string[] args )
		{
			BigInteger a = BigInteger.Parse ( Console.ReadLine () );
			BigInteger code = BigInteger.Parse ( Console.ReadLine () );
			BigInteger c = BigInteger.Parse ( Console.ReadLine () );

			if (a < 0)
			{
				a = a * (-1);
			}

			if (c < 0)
			{
				c = c * (-1);
			}

			if (code < 0)
			{
				code = code * (-1);
			}

			BigInteger res = 0;
			BigInteger outp = 0;

			if (code == 2)
			{
				res = a % c;
			}

			if (code == 4)
			{
				res = a + c;
			}

			if (code == 8)
			{
				res = a * c;
			}

			if (res % 4 == 0)
			{
				outp = res / 4;
			}

			if (res % 4 != 0)
			{
				outp = res % 4;
			}

			Console.WriteLine (outp);
			Console.WriteLine (res);
		}
	}
}
