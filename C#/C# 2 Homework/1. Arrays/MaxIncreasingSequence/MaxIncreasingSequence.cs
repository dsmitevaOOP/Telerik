using System;

//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

class MaxIncreasingSequence
{
	static void Main ()
	{
		Console.Write ( "Enter size of the array: " );
		int size = int.Parse ( Console.ReadLine () );


		int[] arr = new int[size];

		for (int i = 0; i < size; i++)
		{
			Console.Write ( "Enter value: " );
			arr[i] = int.Parse ( Console.ReadLine () );
		}

		int count = 0;
		int maxCount = 0;
		int currentInt = 0;
		int maxInt = 0;

		for (int i = 0; i < arr.Length - 1; i++)
		{
			if (arr[i] < arr[i + 1])
			{
				count++;
				currentInt = arr[i + 1];
			}
			else
			{
				count = 0;
			}
			if (count >= maxCount)
			{
				maxCount = count;
				maxInt = currentInt;
			}
		}

		int k = 0;

		for (int i = 0; i < maxCount + 1; i++)
		{
			Console.Write ( (maxInt - k) + " " );
			k++;
		}
		Console.WriteLine ();
	}
}
