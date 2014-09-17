using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BinaryDigitsCount
{
	class BinaryDigitsCount
	{
		static void Main ( string[] args )
		{
			char b = char.Parse (Console.ReadLine());
			int n = int.Parse (Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				long num = long.Parse (Console.ReadLine());
				int counter = 0;
				string bin = Convert.ToString (num, 2);
				char[] count = bin.ToCharArray();

				for (int j = 0; j < count.Length; j++)
				{
					if (count[j] == b)
					{
						counter++;
					}
				}

				Console.WriteLine (counter);
			}
		}
	}
}
