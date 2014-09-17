﻿using System;
using System.Numerics;

//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

class FibonacciSequenceN
{
	static void Main ()
	{
		Console.Write ("Enter some integer: ");
		int N = int.Parse(Console.ReadLine ());

		BigInteger memb1 = 0;
		BigInteger memb2 = 1;

		for (int i = 1; i <= N; i++)
		{
			if (i != N)
			{
				Console.Write ( memb1 + ", " );
			}
			else
			{
				Console.Write ( memb1 + ". " );
			}
			BigInteger memb3 = memb1 + memb2;
			memb1 = memb2;
			memb2 = memb3;
		}
	}
}

