using System;

//Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

class MaximalSequenceOfEqualElements
{
	static void Main ()
	{
		Console.Write ("Enter size of the array: ");
		int size = int.Parse (Console.ReadLine());


		int[] arr = new int[size];

		for (int i = 0; i < size; i++)
		{
			Console.Write ("Enter value: ");
			arr[i] = int.Parse (Console.ReadLine());
		}

		int count = 0;
		int maxCount = 0;
		int currentInt = 0;
		int maxInt = 0;

		for (int i = 0; i < arr.Length - 1; i++)
		{
			if (arr[i] == arr[i + 1])
            {
                count++;
                currentInt = arr[i];
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

		for (int i = 0; i < maxCount + 1; i++)
		{
			Console.Write ( maxInt + " ");
		}
		Console.WriteLine ();
	}
}

