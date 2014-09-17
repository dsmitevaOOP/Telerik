using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetSum
{
	class SubsetSum
	{
		static void Main ( string[] args )
		{
			long S = long.Parse (Console.ReadLine());
			int n = int.Parse(Console.ReadLine());
			long[] num = new long[17];

			for (int i = 1; i <= 16; i++)
			{
				num[i] = 0;
			}

			for (int i = 1; i <= n; i++)
			{
				num[i] = long.Parse (Console.ReadLine());
			}

			int answer = 0;
			int maxi = (int) Math.Pow ( 2, n ) - 1;

			for (int i = 1; i <= maxi; i++)
			{
				long currentSum = 0;
				for (int j = 1; j <= n; j++)
				{
					if (((i >> (j - 1)) & 1) == 1)
					{
						currentSum = currentSum + num[j];
					}
				}
				if (currentSum == S) answer++;
			}

			Console.WriteLine ( answer );
		}
	}
}
