using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coockie
{
	class Program
	{
		static void Main ( string[] args )
		{
			string[] my = new string[16];
			bool cooc = false;
			int t = 0;
			for (int i = 0; i < 16; i++)
			{
				my[i] = Console.ReadLine ();
			}
			string question = Console.ReadLine ();
			if (question == "what is")
			{
				while (question == "what is")
				{
					int row = int.Parse ( Console.ReadLine () );
					int col = int.Parse ( Console.ReadLine () );

					if ((my[row - 1][col - 1] == 1) && (my[row - 1][col] == 1) && (my[row - 1][col + 1] == 1) && (my[row + 1][col - 1] == 1) && (my[row + 1][col] == 1) && (my[row - 1][col + 1] == 1) && (my[row][col - 1] == 1) && (my[row - 1][col - 1] == 1) && (my[row - 1][col + 1] == 1))
					{
						Console.WriteLine ( "cookie" );
						cooc = true;
					}

					if (((my[row - 1][col - 1] == 1) && (my[row - 1][col] == 1) && (my[row - 1][col + 1] == 1) && (my[row - 2][col - 1] == 1) && (my[row - 2][col] == 1) && (my[row - 2][col + 1] == 1) && (my[row][col - 1] == 0) && (my[row - 1][col - 1] == 0) && (my[row - 1][col + 1] == 0)) || ((my[row + 1][col - 1] == 1) && (my[row + 1][col] == 1) && (my[row + 1][col + 1] == 1) && (my[row + 2][col - 1] == 1) && (my[row + 2][col] == 1) && (my[row + 2][col + 1] == 1) && (my[row][col - 1] == 0) && (my[row - 1][col - 1] == 0) && (my[row - 1][col + 1] == 0)))
					{
						Console.WriteLine ( "cookie crumb" );
					}

					if ((my[row - 1][col - 1] == 0) || (my[row - 1][col] == 0) || (my[row - 1][col + 1] == 0) || (my[row + 1][col - 1] == 0) || (my[row + 1][col] == 0) || (my[row - 1][col + 1] == 0) || (my[row][col - 1] == 0) || (my[row - 1][col - 1] == 0) || (my[row - 1][col + 1] == 0))
					{
						Console.WriteLine ( "cookie crumb" );
					}
				}
			}

			if (question == "buy")
			{
				while (question == "buy")
				{
					int row = int.Parse ( Console.ReadLine () );
					int col = int.Parse ( Console.ReadLine () );

					if ((my[row - 1][col - 1] == 1) && (my[row - 1][col] == 1) && (my[row - 1][col + 1] == 1) && (my[row + 1][col - 1] == 1) && (my[row + 1][col] == 1) && (my[row - 1][col + 1] == 1) && (my[row][col - 1] == 1) && (my[row - 1][col - 1] == 1) && (my[row - 1][col + 1] == 1))
					{
						t++;

					}
				}
			}
		}
	}
}
