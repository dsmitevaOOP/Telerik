using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestRoad
{
	class ForestRoad
	{
		static void Main ( string[] args )
		{
			int n = int.Parse ( Console.ReadLine () );

			for (int i = 1; i <= n; i++)
			{
				Console.Write ( new string ( '.', (i - 1) ) );
				Console.Write ( "*" );
				Console.Write ( new string ( '.', (n - (i - 1) - 1) ) );
				Console.WriteLine ();
			}

			for (int i = 2; i <= n; i++)
			{
				Console.Write ( new string ( '.', (n - (i - 1) - 1) ) );
				Console.Write ( "*" );
				Console.Write ( new string ( '.', (i - 1) ) );
				Console.WriteLine ();
			}
		}
	}
}
