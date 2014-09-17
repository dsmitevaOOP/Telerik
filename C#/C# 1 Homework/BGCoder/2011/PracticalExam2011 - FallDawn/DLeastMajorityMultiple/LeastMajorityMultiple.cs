using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastMajorityMultiple
{
	class LeastMajorityMultiple
	{
		static void Main ( string[] args )
		{
			int a = int.Parse (Console.ReadLine());
			int b = int.Parse ( Console.ReadLine () );
			int c = int.Parse ( Console.ReadLine () );
			int d = int.Parse ( Console.ReadLine () );
			int e = int.Parse ( Console.ReadLine () );
			int count = 0;
			int count3 = 0;
			int count4 = 0;
			int count5 = 0;
			int res = 0;

			for (int i = 1; i <= 1000000; i++)
			{
				count = 0;

				if (i % a == 0)
				{
					count++;
				}

				if (i % b == 0)
				{
					count++;
				}

				if (i % c == 0)
				{
					count++;
				}

				if (i % d == 0)
				{
					count++;
				}

				if (i % e == 0)
				{
					count++;
				}

				if (count == 3)
				{
					count3 = i;
					break;
				}
			}

			for (int i = 1; i <= 1000000; i++)
			{
				count = 0;

				if (i % a == 0)
				{
					count++;
				}

				if (i % b == 0)
				{
					count++;
				}

				if (i % c == 0)
				{
					count++;
				}

				if (i % d == 0)
				{
					count++;
				}

				if (i % e == 0)
				{
					count++;
				}

				if (count == 4)
				{
					count4 = i;
					break;
				}
			}

			for (int i = 1; i <= 1000000; i++)
			{
				count = 0;

				if (i % a == 0)
				{
					count++;
				}

				if (i % b == 0)
				{
					count++;
				}

				if (i % c == 0)
				{
					count++;
				}

				if (i % d == 0)
				{
					count++;
				}

				if (i % e == 0)
				{
					count++;
				}

				if (count == 5)
				{
					count5 = i;
					break;
				}
			}

				if (count3 == 0)
				{
					if (count4 == 0)
					{
						if (count5 == 0)
						{
							res = 0;
						}
						else
						{
							res = count5;
						}
					}
					else
					{
						if (count5 == 0)
						{
							res = count4;
						}
						else
						{
							res = Math.Min ( count4, count5 );
						}
					}
				}
				else
				{
					if (count4 == 0)
					{
						if (count5 == 0)
						{
							res = count3;
						}
						else
						{
							res = Math.Min ( count3, count5 );
						}
					}
					else
					{
						if (count5 == 0)
						{
							res = Math.Min ( count3, count4 );
						}
						else
						{
							res = Math.Min (count3, Math.Min(count4, count5));
						}
					}
			}

			Console.WriteLine ( res );
		}
	}
}
