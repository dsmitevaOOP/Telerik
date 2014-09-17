using System;

//Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

class GetMax
{
	static int GetMaxim (int first, int sec)
	{
		int result = 0;

		if (first > sec)
		{
			result = first;
		}
		else
		{
			result = sec;
		}

		return result;
	}

	static void Main ()
	{
		int a = int.Parse (Console.ReadLine());
		int b = int.Parse ( Console.ReadLine () );
		int c = int.Parse ( Console.ReadLine () );

		int res = GetMaxim (GetMaxim(a, b), c);
		Console.WriteLine (res);
	}
}

