using System;

//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
//N = 3					N = 4
//1, 2, 3				1, 2, 3, 4
//2, 3, 4				2, 3, 4, 5
//3, 4, 5				3, 4, 5, 6
//						4, 5, 6, 7
class Matrix
{
	static void Main ()
	{
		Console.Write ( "Enter some integer (N < 20): " );
		int N = int.Parse ( Console.ReadLine () );

		for (int row = 1; row <= N; row++)
		{
			for (int col = 1; col <= N; col++)
			{
				int t = row + col - 1;
				Console.Write ( t + ", " );
			}
			Console.WriteLine ();
		}
	}
}

