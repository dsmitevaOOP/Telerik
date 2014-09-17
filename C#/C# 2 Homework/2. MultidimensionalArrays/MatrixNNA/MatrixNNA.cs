using System;

class MatrixNNA
{
	static void Main ()
	{
		Console.Write ( "Enter size of the matrix: " );
		int size = int.Parse ( Console.ReadLine () );

		int[,] matrix = new int[size, size];
		int k = 1;

		for (int col = 0; col < size; col++)
		{
			for (int row = 0; row < size; row++)
			{
				matrix[col, row] = k;
				k++;
			}
		}

		for (int i = 0; i < size; i++)
		{
			for (int j = 0; j < size; j++)
			{
				Console.Write (matrix[j,i] + " ");
			}
			Console.Write ("\n");
		}
	}
}
