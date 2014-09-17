using System;

//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

class ReturnIndex
{
	static int IsBigger(int[] arr)
	{
		int pos = 0;

		for (int i = 1; i < arr.Length - 1; i++)
		{
			if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
			{
				 pos = i;
			}
		}

		return pos;
	}

	static void Main ()
	{
		Console.Write ( "Enter size of the array: " );
		int size = int.Parse ( Console.ReadLine () );

		int[] array = new int[size];

		for (int i = 0; i < array.Length; i++)
		{
			Console.Write ( "Enter value for the {0} element of the array: ", i );
			array[i] = int.Parse ( Console.ReadLine () );
		}

		int res = IsBigger ( array );
		Console.WriteLine (res);
	}
}

