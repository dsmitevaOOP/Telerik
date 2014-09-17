using System;

//Write a program that prints all the numbers from 1 to N

class NumbersOneToN
{
	static void Main ()
	{
		Console.Write ("Enter some number: ");
		int num = int.Parse(Console.ReadLine ());

		if (num < 0)
		{
			while (num < 0)
			{
				Console.WriteLine ( "Invalid input!" );
				Console.Write ( "Enter some number: " );
				num = int.Parse ( Console.ReadLine () );
			}
		}
		
		for (int i = 1; i < num; i++)
		{
			Console.Write(i +" ");
		}

		Console.Write (num);
		Console.WriteLine ();
	}
}

