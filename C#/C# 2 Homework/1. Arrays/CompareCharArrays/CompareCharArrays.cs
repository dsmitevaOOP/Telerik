using System;

// Write a program that compares two char arrays lexicographically (letter by letter).

class CompareCharArrays
{
	static void Main ()
	{
		Console.Write ("Enter the size of the array: ");
		int size = int.Parse (Console.ReadLine());

		char[] first = new char[size];
		char[] sec = new char[size];

		for (int i = 0; i < size; i++)
		{
			Console.Write ("Ente value for the first array: ");
			first[i] = char.Parse (Console.ReadLine());

			Console.Write ( "Ente value for the second array: " );
			sec[i] = char.Parse ( Console.ReadLine () );
		}

		for (int i = 0; i < size; i++)
		{
			if (first[i] == sec[i])
			{
				Console.WriteLine ("The element from the first array is equal to the element from the second array.");
			}

			if (first[i] != sec[i])
			{
				Console.WriteLine ("The elements from the first and the second array are not equal.");
			}
		}
	}
}

