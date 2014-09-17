using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumberAuthor
{
	class OddNumberAuthor
	{
		static void Main ( string[] args )
		{
			int n = int.Parse ( Console.ReadLine () );
			long result = 0;

			for (int i = 0; i < n; i++)

			{
				long current = long.Parse(Console.ReadLine());
				result ^= current;
			}

			Console.WriteLine(result);
		}
	}
}
