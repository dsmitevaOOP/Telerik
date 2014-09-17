using System;

//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1 --> false.

class Mask
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
			bool result = bit == 1 ? true : false;
			Console.WriteLine(result);
		}
	}

