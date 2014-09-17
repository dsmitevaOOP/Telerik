using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace NightmareOnCodeStreet
{
	class NightmareOnCodeStreet
	{
		static void Main ( string[] args )
		{
			string input = Console.ReadLine ();

			char[] arr = input.ToCharArray ();
			BigInteger sum = 0;
			int count = 0;
			char[] myArr = new char[arr.Length];
			int k = 0;
			int h = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				int t = (int) (arr[i]);
				if ((t < 48) || (t > 57))
				{
					h++;
					continue;
				}
				else if (arr[i] == '*')
				{
					continue;
				}
				else
				{
					myArr[k] = arr[i];
					k++;
				}
			}

			if (h == arr.Length)
			{
				return;
			}

			for (int i = 0; i < arr.Length; i++)
			{
				if (i % 2 == 0)
				{
					continue;
				}

				if (i % 2 != 0)
				{
					string my = Convert.ToString ( myArr[i] );
					BigInteger dig = BigInteger.Parse ( my );
					sum = sum + dig;
					count++;
				}
			}

			Console.WriteLine ( "{0} {1}", count, sum );
		}
	}
}
