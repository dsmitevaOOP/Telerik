using System;

// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

class LeapYear
{
	static void Main ()
	{
		Console.Write ("Enter year: ");
		int year = int.Parse (Console.ReadLine());

		bool isLeap = DateTime.IsLeapYear ( year );
		Console.WriteLine (isLeap);
	}
}

