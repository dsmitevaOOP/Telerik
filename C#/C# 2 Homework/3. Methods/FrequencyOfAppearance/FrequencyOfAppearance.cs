using System;

//Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.

	class FrequencyOfAppearance
	{
		static int Frequency (double[] arr, double num)
		{
			int count = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == num)
				{
					count++;
				}
			}

			return count;
		}

		static void Main ( )
		{
			Console.Write("Enter size of the array: ");
			int size = int.Parse(Console.ReadLine());

			Console.Write("Enter number to be checked: ");
			double check = double.Parse(Console.ReadLine());

			double[] array = new double[size];

			for (int i = 0; i < array.Length; i++)
			{
				Console.Write ( "Enter value for the {0} element of the array: ", i);
				array[i] = double.Parse ( Console.ReadLine () );
			}

			int res = Frequency (array, check);
			Console.WriteLine (res);
		}
	}

