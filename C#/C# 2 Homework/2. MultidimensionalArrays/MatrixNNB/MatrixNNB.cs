using System;

class MatrixNNB
{
	static void Main ()
	{
		Console.Write ( "Enter size of the matrix: " );
		int size = int.Parse ( Console.ReadLine () );

		int[,] matrix = new int[size, size];
		int count = 1;

		for (int i = 0; i < size; i++)
		{
			if (i % 2 == 0)
			{
				for (int j = 0; j < size; j++)
				{
					matrix[j, i] = count++;
				}
			}
			else
			{
				for (int j = size - 1; j >= 0; j--)
				{
					matrix[j, i] = count++;
				}
			}
		}

		for (int i = 0; i < size; i++)
		{
			for (int j = 0; j < size; j++)
			{
				Console.Write (matrix[i, j] + " ");
			}
			Console.Write ("\n");
		}
	}
}

