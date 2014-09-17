using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkenNumbers
{
	class DrunkenNumbers
	{
		static void Main ( string[] args )
		{
			int rounds = int.Parse ( Console.ReadLine () );
			int mitko = 0;
			int vladko = 0;

			for (int i = 1; i <= rounds; i++)
			{
				int num = int.Parse ( Console.ReadLine () );
				if (num < 0)
				{
					num = num * (-1);
				}

				int n = num;
				int count = 0;

				while (num > 0)
				{
					num = num / 10;
					count++;
				}

				if ((count % 2) == 0)
				{
					for (int j = 1; j <= count; j++)
					{
						if (j <= count / 2)
						{
							int add = n % 10;
							n = n / 10;
							vladko = vladko + add;
						}

						if (j > count / 2)
						{
							int add = n % 10;
							n = n / 10;
							mitko = mitko + add;
						}
					}
				}
				else
				{
					for (int j = 1; j <= count; j++)
					{
						if (j == (count / 2) + 1)
						{
							int add = n % 10;
							n = n / 10;
							vladko = vladko + add;
							mitko = mitko + add;
						}
						else if (j <= count / 2)
						{
							int add = n % 10;
							n = n / 10;
							vladko = vladko + add;
						}
						else if (j > count / 2)
						{
							int add = n % 10;
							n = n / 10;
							mitko = mitko + add;
						}
					}
				}
			}

			if (mitko > vladko)
			{
				Console.WriteLine ( "M" + " " + (mitko - vladko) );
			}
			else if (mitko < vladko)
			{
				Console.WriteLine ( "V" + " " + (vladko - mitko) );
			}
			else if (mitko == vladko)
			{
				Console.WriteLine ( "No" + " " + (mitko + vladko) );
			}
		}
	}
}
