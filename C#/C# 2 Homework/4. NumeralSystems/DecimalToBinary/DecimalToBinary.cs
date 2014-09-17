using System;

// Write a program to convert decimal numbers to their binary representation.

class DecimalToBinary
{
	static void Main ()
	{
		Console.Write ("Enter some number: ");
		int decim = int.Parse (Console.ReadLine());

		string my = "";

		while (decim > 0)
		{
			int temp = decim % 2;
			decim = decim / 2;
			my = my + Convert.ToString (temp);
		}

		string res = "";

		for (int i = my.Length - 1; i >= 0; i--)
		{
			res = res + my[i];
		}

		Console.WriteLine (res);
	}
}

