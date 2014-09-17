using System;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

class SortingArray
{
	static void Main ()
	{
		Console.Write ("Enter size of the array: ");
		int size = int.Parse (Console.ReadLine());

		int[] array = new int[size];

		for (int i = 0; i < size; i++)
		{
			Console.Write ("Eneter value for the {0} element ", i);
			array[i] = int.Parse (Console.ReadLine());
		}

		for (int i = 0; i < size - 1; i++)
		{
			for (int j = i + 1; j < size; j++)
			{
				if (array[i] > array[j])
				{
					int temp = array[i];
					array[i] = array[j];
					array[j] = temp;
				}
			}
		}

		for (int i = 0; i < size; i++)
		{
			Console.Write (array[i] + " ");
		}
	}
}

