using System;

//Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.

class ArrNMaxSumOfKElements
{
	static void Main ()
	{
		Console.Write ("Enter size of the array: ");
		int size = int.Parse (Console.ReadLine());

		Console.Write ( "Enter number of elements to be summed: " );
		int numberOfElements = int.Parse ( Console.ReadLine () );

		int[] array = new int[size];

		for (int i = 0; i < size; i++)
		{
			Console.Write ("Enter value: ");
			array[i] = int.Parse (Console.ReadLine());
		}

		Array.Sort ( array );
		Array.Reverse ( array );

		for (int i = 0; i < numberOfElements; i++)
		{
			Console.Write (array[i] + " ");
		}
	}
}

