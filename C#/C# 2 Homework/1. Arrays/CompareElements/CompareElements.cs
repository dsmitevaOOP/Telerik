using System;

// Write a program that reads two arrays from the console and compares them element by element.

class Program
{
	static void Main ( )
	{
		Console.Write ("Enter the size of the array: ");
		int size = int.Parse(Console.ReadLine());

		int[] arrFirst = new int[size];
		int[] arrSec = new int[size];

		for (int i = 0; i < size; i++)
		{
			Console.Write ("Enter value for the {0} element of the first array: ", i);
			arrFirst[i] = int.Parse ( Console.ReadLine () );

			Console.Write ( "Enter value for the {0} element of the second array: ", i );
			arrSec[i] = int.Parse ( Console.ReadLine () );
		}

		for (int i = 0; i < size; i++)
		{
			if (arrFirst[i] == arrSec[i])
			{
				Console.WriteLine ("Equal");
			}

			if (arrFirst[i] > arrSec[i])
			{
				Console.WriteLine ("First is greater than second");
			}

			if (arrFirst[i] < arrSec[i])
			{
				Console.WriteLine ("Second is greater than first");
			}
		}
	}
}

