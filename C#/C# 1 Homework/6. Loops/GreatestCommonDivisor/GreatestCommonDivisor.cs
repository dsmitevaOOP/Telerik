using System;

// Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

class GreatestCommonDivisor
{
	static void Main ()
	{
		Console.Write ("Enter the first number: ");
		int first = int.Parse(Console.ReadLine ());

		Console.Write ("Enter the second number: ");
		int sec = int.Parse(Console.ReadLine ());

		if (first > sec)
		{
			first = first + sec;
			sec = first - sec;
			first = first - sec;
		}

		int gcd = sec % first;
		bool res = false;
		do
		{
			gcd = first % gcd;
			res = gcd > 0;
		} while (!res);

		Console.WriteLine ("{0}", gcd);
	}
}

