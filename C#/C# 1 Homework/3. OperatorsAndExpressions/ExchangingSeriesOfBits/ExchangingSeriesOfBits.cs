using System;

//* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

class ExchangingSeriesOfBits
	{
	static void Main()
		{
			Console.Write("Enter some integer: ");
			int myInt = int.Parse(Console.ReadLine());
			Console.Write("Enter the position of the first bit to be changed: ");
			int pos = int.Parse(Console.ReadLine());
			Console.Write("Enter the position of the first bit with wich the bits will be changed: ");
			int change = int.Parse(Console.ReadLine());
			Console.Write("Enter number of bits after the first one: ");
			int step = int.Parse(Console.ReadLine());
			int mask = 1 << step;
			mask = mask - 1;
			mask = mask << change;
			int firstMidRes = myInt & mask;
			if (pos < change)
				{
					firstMidRes = firstMidRes >> (change - pos);
				}
			else
				{
					firstMidRes = firstMidRes << (pos - change);
				}
			mask = ~mask;
			if (pos < change)
				{
					mask = mask >> (change - pos);
				}
			else
				{
					mask = mask << (pos - change);
				}
			int secMidRes = myInt & mask;
			int res = secMidRes | firstMidRes;
			Console.WriteLine("This is the result:  " + Convert.ToString(myInt, 2).PadLeft(32, '0'));
			Console.WriteLine("This is the integer: " + Convert.ToString(res, 2).PadLeft(32, '0'));
		}
	}