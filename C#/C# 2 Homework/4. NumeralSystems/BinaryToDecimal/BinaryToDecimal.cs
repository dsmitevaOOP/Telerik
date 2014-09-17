using System;

// Write a program to convert binary numbers to their decimal representation.

class BinaryToDecimal
{
	static void Main ()
	{
		Console.Write ("Enter some binary number: ");
		string input = Console.ReadLine ();

		int res = 0;
		int temp = 0;

		for (int i = input.Length - 1; i >= 0; i--)
		{
			int tempRes = 0;
			string some = Convert.ToString ( input[temp] );
			int parse = int.Parse (some);

			if (parse == 1)
			{
				tempRes = (int) Math.Pow (2, i );
			}

			if (parse == 0)
			{
				tempRes = 0;
			}

			res = res + tempRes;
			temp++;
		}

		Console.WriteLine (res);
	}
}

