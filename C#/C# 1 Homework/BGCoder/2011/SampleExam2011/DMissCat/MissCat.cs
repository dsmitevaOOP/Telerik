using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissCat
{
	class MissCat
	{
		public enum Cats {cat1 = 1, cat2, cat3, cat4, cat5, cat6, cat7, cat8, cat9, cat10 }

		static void Main ( string[] args )
		{
			int jury = int.Parse (Console.ReadLine());
			int[] cat = new int[11];
			int winner = 1;

			for (int c = 1; c <= 10; c++)
			{
				cat[c] = 0;
			}
		
			for (int i = 1; i <= jury; i++)
			{
				int a = int.Parse (Console.ReadLine());
				Cats someCats = (Cats) a;

				switch (someCats)
				{
					case Cats.cat1:
						cat[1]++;
						break;
					case Cats.cat2:
						cat[2]++;
						break;
					case Cats.cat3:
						cat[3]++;
						break;
					case Cats.cat4:
						cat[4]++;
						break;
					case Cats.cat5:
						cat[5]++;
						break;
					case Cats.cat6:
						cat[6]++;
						break;
					case Cats.cat7:
						cat[7]++;
						break;
					case Cats.cat8:
						cat[8]++;
						break;
					case Cats.cat9:
						cat[9]++;
						break;
					case Cats.cat10:
						cat[10]++;
						break;
				}

				int win = cat[1];

				for (int j = 2; j <= 10; j++)
				{
					if (cat[j] > win)
					{
						winner = j;
						win = cat[j];
					}
				}

				for (int j = 1; j <= 10; j++)
				{
					if (j == winner)
					{
						continue;
					}

					if (cat[j] == win)
					{
						if (j < winner)
						{
							winner = j;
							win = cat[j];
						}
					}
				}
			}

			Console.WriteLine (winner);
		}
	}
}
