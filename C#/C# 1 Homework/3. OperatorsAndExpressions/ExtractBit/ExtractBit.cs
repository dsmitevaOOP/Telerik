using System;

//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2 --> value=1.

class ExtractBit
	{
	static void Main()
		{
			Console.Write("Enter an integer: ");
			int someInt = int.Parse(Console.ReadLine());
			Console.Write("Enter the position of the bit to be checked: ");
			int pos = int.Parse(Console.ReadLine());
			int mask = 1 << pos;
			int someIntAndMask = someInt & mask;
			int bit = someIntAndMask >> pos;
			Console.WriteLine("The value of the bit at position {0} is {1}", pos, bit);
		}
	}

