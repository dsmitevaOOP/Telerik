using System;

	class SumFiveNumbers
	{
		static void Main ( )
		{
			Console.Write ("Enter 5 numbers: ");
			string input = Console.ReadLine ();

			string[] split = input.Split ( new char[] { ' ' } );
			double sum = 0;

			for (int i = 0; i < split.Length; i++)
			{
				double temp = double.Parse(split[i]);
				sum = sum + temp;
			}

			Console.WriteLine (sum);
		}
	}

