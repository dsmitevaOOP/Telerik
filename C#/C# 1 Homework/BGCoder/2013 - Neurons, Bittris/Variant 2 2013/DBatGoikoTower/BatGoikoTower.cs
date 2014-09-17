using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatGoikoTower
{
	class BatGoikoTower
	{
		static void Main ( string[] args )
		{
			int n = int.Parse ( Console.ReadLine () );
			int t = 2;
			int res = 1;

			for (int rows = 1; rows <= n; rows++)
			{
				if (rows - 1 == res)
				{
					Console.Write ( new string ( '.', (n - rows) ) );
					Console.Write ( "/" );
					Console.Write ( new string ( '-', (rows - 1) * 2 ) );
					Console.Write ( "\\" );
					Console.WriteLine ( new string ( '.', (n - rows) ) );
					res = res + t;
					t++;
				}
				else
				{
					Console.Write ( new string ( '.', (n - rows) ) );
					Console.Write ( "/" );
					Console.Write ( new string ( '.', (rows - 1) * 2 ) );
					Console.Write ( "\\" );
					Console.WriteLine ( new string ( '.', (n - rows) ) );
				}
			}
		}
	}
}
