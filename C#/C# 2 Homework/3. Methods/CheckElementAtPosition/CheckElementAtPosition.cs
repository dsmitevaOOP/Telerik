using System;

//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

class CheckElementAtPosition
{
	static bool IsBigger (int[] arr, int position)
	{
		bool res = false;

		if (position != 0 && position != (arr.Length - 1))
		{
			if (arr[position] > arr[position + 1] && arr[position] >arr[position - 1])
			{
				res = true;
			}	
		}

		return res;
	}

	static void Main ( )
	{
		Console.Write ("Enter size of the array: ");
		int size = int.Parse (Console.ReadLine());

		Console.Write ("Enter position to be checked: ");
		int pos = int.Parse (Console.ReadLine());

		int[] array = new int[size];

		for (int i = 0; i < array.Length; i++)
		{
			Console.Write ( "Enter value for the {0} element of the array: ", i );
			array[i] = int.Parse ( Console.ReadLine () );
		}

		bool res = IsBigger (array, pos);
		Console.WriteLine (res);
	}
}

