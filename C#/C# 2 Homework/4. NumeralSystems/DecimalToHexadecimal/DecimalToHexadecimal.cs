using System;

// Write a program to convert decimal numbers to their hexadecimal representation.

class Program
{
	static void Main ()
	{
		Console.Write ("Enter some number: ");
		int dec = int.Parse (Console.ReadLine());

		string my = "";

		while (dec > 0)
		{
			int temp = dec % 16;
			dec = dec / 16;

			if (temp >= 0 && temp < 10)
			{
				my = my + Convert.ToString ( temp );
			}
			else if (temp == 10)
			{
				my = my + "A";
			}
			else if (temp == 11)
			{
				my = my + "B";
			}
			else if (temp == 12)
			{
				my = my + "C";
			}
			else if (temp == 13)
			{
				my = my + "D";
			}
			else if (temp == 14)
			{
				my = my + "E";
			}
			else if (temp == 15)
			{
				my = my + "F";
			}
		}

		string res = "";

		for (int i = my.Length - 1; i >= 0; i--)
		{
			res = res + my[i];
		}

		Console.WriteLine ( res );
	}
}

