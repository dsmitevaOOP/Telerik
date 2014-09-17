using System;
using System.Numerics;

//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

class TheSequenceOfFibonacci
	{
	static void Main()
		{
			BigInteger memb1 = 0;
			BigInteger memb2 = 1;
			for (int i = 0; i < 100; i++)
				{
					Console.Write(memb1 + ", ");
					BigInteger memb3 = memb1 + memb2;
					memb1 = memb2;
					memb2 = memb3;
				}
		}
	}

