using System;

//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

class FindingThirdBit
	{
	static void Main()
		{
			Console.WriteLine("The program checks if bit 3 of a given integer is 1 (true) or 0 (false)");
			Console.Write("Enter some integer: ");
			int someInt = int.Parse(Console.ReadLine());
			int mask = 1 << 3;
			int myIntAndMask = someInt & mask;
			int bit = myIntAndMask >> 3;
			bool result = bit == 1 ? true : false;
			Console.WriteLine(result);
		}
	}

