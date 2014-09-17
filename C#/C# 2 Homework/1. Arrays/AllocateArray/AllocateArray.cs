using System;

// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

class AllocateArray
{
	static void Main ( )
	{
		int[] arr = new int[20];

		for (int i = 0; i < arr.Length; i++)
		{
			arr[i] = 5 * i;
		}

		for (int i = 0; i < arr.Length; i++)
		{
			Console.Write ("{0} ", arr[i]);
		}
	}
}

