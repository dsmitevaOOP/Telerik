using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
	class OddNumber
	{
		static void Main ( string[] args )
		{
			int n = int.Parse (Console.ReadLine());
			string[] num = new string[n];

			for (int i = 0; i < num.Length; i++)
			{
				num[i] = Console.ReadLine();
			}

			for (int i = 0; i < num.Length; i++)
			{
				int count = 0;

				for (int j = 0; j < num.Length; j++)
				{
					if (i == j)
					{
						continue;
					}

					if (num[i] == num[j])
					{
						count++;
					}
				}
				
				if (count % 2 == 0)
				{
					Console.WriteLine (num[i]);
				}				
			}
		}
	}
}
