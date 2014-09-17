using System;

// Write a program to convert binary numbers to hexadecimal numbers (directly).

class HexidecimalToBinary
{
	static void Main ()
	{
		Console.Write ("Enter binary number: ");
		string input = Console.ReadLine ();

		if (input.Length % 4 != 0)
		{
			int my = 4 - input.Length % 4;
			string temp = new string ( '0', my );
			input = temp + input;
		}

		int size = input.Length / 4;
		string[] array = new string[size];
		int x = 0;

		for (int i = 0; i < size; i++)
		{
			string my = "";

			for (int j = x; j < x + 4; j++)
			{
				my = my + input[j];
			}

			array[i] = my;
			x = x + 4;
		}

		int res = 0;
		int count = 0;
		string result = "";

		for (int i = 0; i < size; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				string inp = array[i];
				int tempRes = 0;
				string some = Convert.ToString ( inp[count] );
				int parse = int.Parse ( some );

				if (parse == 1)
				{
					tempRes = (int) Math.Pow ( 2, i );
				}

				if (parse == 0)
				{
					tempRes = 0;
				}

				res = res + tempRes;
			}

			string any = Convert.ToString ( res );
			result = result + any;
			count++;
		}

		Console.WriteLine (result);
	}
}

