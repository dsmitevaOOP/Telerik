using System;
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

class Change3Bits
	{
	static void Main()
		{
			Console.Write("Enter some integer: ");
			int myInt = int.Parse(Console.ReadLine());
			int mask = 1 << 3;
			mask = mask - 1;
			mask = mask << 25;
			int firstMidRes = myInt & mask;
			firstMidRes = firstMidRes >> 22;
			mask = ~mask;
			mask = mask >> 22;
			int secMidRes = myInt & mask;
			int res = secMidRes | firstMidRes;
			Console.WriteLine("This is the result:  " + Convert.ToString(myInt, 2).PadLeft(32, '0'));
			Console.WriteLine("This is the integer: " + Convert.ToString(res, 2).PadLeft(32, '0'));
		}
	}

