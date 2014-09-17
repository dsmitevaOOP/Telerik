using System;

//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

class MinimalAndMaximal
{
	static void Main ()
	{
		Console.Write ("Enter how many numbers you want to input: ");
		int num = int.Parse(Console.ReadLine ());
		int[] array = new int[num];
		for (int i = 0; i < array.Length; i++)
		{
			Console.Write ("Enter number: ");
			array[i] = int.Parse ( Console.ReadLine () );
		}

		int maxValue = array[0];
		foreach (int n in array)
		{
			if (n > maxValue)
			{
				maxValue = n;
			}
		}
		Console.WriteLine ("The maximal of the numbers you have entered is {0}", maxValue);

		int minValue = array[0];
		foreach (int n in array)
		{
			if (n < minValue)
			{
				minValue = n;
			}
		}
		Console.WriteLine ("The minimal of the numbers you have entered is {0}", minValue);

		double sum = 0;
		for (int i = 0; i < array.Length; i++)
		{
			sum = sum + array[i];
		}
		Console.WriteLine ("The sum of the numbers you have entered is {0}", sum);

		double avarage = sum / num;

		Console.WriteLine ("The avarage is {0: 0.00}", avarage);
	}
}

