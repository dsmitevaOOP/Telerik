using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire
{
	class Fire
	{
		static void Main ( string[] args )
		{
			int n = int.Parse ( Console.ReadLine () );

			for (int rows = 1; rows <= n / 2; rows++)
			{
				Console.Write (new string ( '.', ((n / 2) - rows) ));
				Console.Write ("#");
				Console.Write (new string ('.', (rows - 1) * 2));
				Console.Write ("#");
				Console.WriteLine (new string ( '.', ((n / 2) - rows) ));
			}

			int m = n - 2;
			for (int rows = 1; rows <= n / 4; rows++)
			{
				Console.Write ( new string ( '.', rows - 1 ) );
				Console.Write ( "#" );
				Console.Write ( new string ( '.', ((n / 2) - rows) * 2 ));
				Console.Write ( "#" );
				Console.WriteLine ( new string ( '.', rows - 1 ) );
			}

			Console.WriteLine (new string ('-', n));

			int s = n / 2;
			for (int rows = 1; rows <= n / 2; rows++)
			{
				Console.Write ( new string ( '.', rows - 1 ) );
				Console.Write ( new string ( '\\', ((n / 2) - (rows - 1)) ) );
				Console.Write ( new string ( '/', ((n / 2) - (rows - 1)) ) );
				s--;
				Console.WriteLine ( new string ( '.', rows - 1 ) );
			}
		}
	}
}
