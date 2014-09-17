using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspichaniaBoats
{
	class KaspichaniaBoats
	{
		static void Main ( string[] args )
		{
			int n = int.Parse (Console.ReadLine());

			Console.Write (new string('.', n));
			Console.Write ("*");
			Console.Write ( new string ( '.', n ) );
			Console.WriteLine ();

			for (int i = 0; i < n - 1; i++)
			{
				Console.Write (new string('.', (n - (i + 1))));
				if (i == 0)
				{
					Console.Write ("***");
					Console.Write ( new string ( '.', (n - (i + 1)) ) );
					Console.WriteLine ();
					continue;
				}
				else
				{
					Console.Write ( "*" );
				}
				Console.Write ( new string ( '.', (i )));
				Console.Write ( "*" );
				Console.Write (new string('.', (i )));
				Console.Write ("*");
				Console.Write ( new string ( '.', (n - (i + 1)) ) );
				Console.WriteLine ();
			}

			Console.WriteLine (new string ('*', (n * 2 + 1) ));

			int t = (n - 3) / 2;
			t = t * 3;
			t = t + 6;
			int f = t - n - 1;

			for (int i = 0; i < f - 1; i++)
			{
				Console.Write ( new string ( '.', (i + 1) )  );
				Console.Write ("*");
				Console.Write ( new string ( '.', (n - i - 2 )  ) );
				Console.Write ( "*" );
				Console.Write ( new string ( '.',(n - i ) ) );
				Console.Write ( "*" );
				Console.Write ( new string ( '.', (i + 1) ) );
				Console.WriteLine ();
			}

			Console.Write (new string ('.', (f)));
			Console.Write (new string('*', n));
			Console.Write ( new string ( '.', (f) ) );
			Console.WriteLine ();
		}
	}
}
