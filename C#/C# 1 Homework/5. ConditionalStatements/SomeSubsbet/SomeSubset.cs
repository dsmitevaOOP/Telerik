using System;

//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 => 1+1-2=0.

class SomeSubset
{
	static void Main ()
	{
		int[] numbers = new int[5];

		for (int i = 0; i < 5; i++)
		{
			Console.Write ( "Enter number: " );
			numbers[i] = int.Parse ( Console.ReadLine () );
		}

		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				int result1 = numbers[i] + numbers[j];
				if (result1 == 0)
				{
					Console.WriteLine ( "{0} + {1} = {2}", numbers[i], numbers[j], result1 );
				}
			}
		}

		for (int i = 0; i < 5; i++)
		{
			for (int j = i + 1; j < 5; j++)
			{
				for (int k = j + 1; k < 5; k++)
				{
					int result2 = numbers[i] + numbers[j] + numbers[k];
					if (result2 == 0)
					{
						Console.WriteLine ( "{0} + {1} + {2} = {3}", numbers[i], numbers[j], numbers[k], result2 );
					}
				}
			}
		}

		for (int i = 0; i < 5; i++)
		{
			for (int j = i + 1; j < 5; j++)
			{
				for (int k = j + 1; k < 5; k++)
				{
					for (int m = k + 1; m < 5; m++)
					{
						int result3 = numbers[i] + numbers[j] + numbers[k] + numbers[m];
						if (result3 == 0)
						{
							Console.WriteLine ( "{0} + {1} + {2} + {3} = {4}",
								numbers[i], numbers[j], numbers[k], numbers[m], result3 );
						}
					}
				}
			}
		}
		int result4 = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];

		if (result4 == 0)
		{
			Console.WriteLine ( "{0} + {1} + {2} + {3} + {4} = {5}",
				numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], result4 );
		}
	}
}

