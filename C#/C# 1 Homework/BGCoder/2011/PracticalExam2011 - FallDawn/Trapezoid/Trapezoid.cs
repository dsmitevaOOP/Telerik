using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
	class Trapezoid
	{
		static void Main ( string[] args )
		{
			int n = int.Parse (Console.ReadLine());
			int k = 1;
			int t = n - 1; 

			Console.Write (new string('.', n));
			Console.Write ( new string ( '*', n ) );
			Console.WriteLine ();

			for (int i = 1; i <= n - 1; i++)
			{
				Console.Write ( new string ( '.', n - i ) );
				Console.Write ("*");
				Console.Write ( new string ( '.', t));
				Console.Write ( "*" );
				Console.WriteLine ();
				t = n - 1 + k;
				k++;
			}
			Console.WriteLine (new string('*', 2 * n));
		}
	}
}
