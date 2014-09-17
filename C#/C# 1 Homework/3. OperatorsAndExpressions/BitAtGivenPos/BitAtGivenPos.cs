using System;

class BitAtGivenPos
{
	static void Main ()
	{
		Console.Write ( "Enter an integer: " );
		int someInt = int.Parse ( Console.ReadLine () );
		Console.Write ( "Enter the position of the bit to be checked: " );
		int pos = int.Parse ( Console.ReadLine () );
		int mask = 1 << pos;
		int someIntAndMask = someInt & mask;
		int bit = someIntAndMask >> pos;

		bool isOne = false;

		if (bit == 1)
		{
			isOne = true;
		}
		else
		{
			isOne = false;
		}

		Console.WriteLine (isOne);
	}
}

