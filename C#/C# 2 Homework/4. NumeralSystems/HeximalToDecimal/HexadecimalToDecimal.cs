using System;

// Write a program to convert hexadecimal numbers to their decimal representation.

class HeximalToDecimal
{
	static void Main ()
	{
		Console.Write ("Enter some hexidecimal number: ");
		string input = Console.ReadLine ();

		int res = 0;
		int temp = 0;

		for (int i = input.Length - 1; i >= 0; i--)
		{
			int tempRes = 0;
			bool val = Char.IsLetter (input[temp]);

			if (val == false)
			{
				string some = Convert.ToString (input[temp]);
				int parse = int.Parse (some);
				tempRes = (int) Math.Pow ( 16, i );
				tempRes = parse * tempRes;
			}
			else if (input[temp] == 'A')
			{
				tempRes = (int) Math.Pow ( 16, i );
				tempRes = 10 * tempRes;
			}
			else if (input[temp] == 'B')
			{
				tempRes = (int) Math.Pow ( 16, i );
				tempRes = 11 * tempRes;
			}
			else if (input[temp] == 'C')
			{
				tempRes = (int) Math.Pow ( 16, i );
				tempRes = 12 * tempRes;
			}
			else if (input[temp] == 'D')
			{
				tempRes = (int) Math.Pow ( 16, i );
				tempRes = 13 * tempRes;
			}
			else if (input[temp] == 'E')
			{
				tempRes = (int) Math.Pow ( 16, i );
				tempRes = 14 * tempRes;
			}
			else if (input[temp] == 'F')
			{
				tempRes = (int) Math.Pow ( 16, i );
				tempRes = 15 * tempRes;
			}

			res = res + tempRes;
			temp++;
		}

		Console.WriteLine (res);
	}
}

