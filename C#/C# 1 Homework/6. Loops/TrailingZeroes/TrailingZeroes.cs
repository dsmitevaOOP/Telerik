using System;
using System.Numerics;

	//* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	//N = 10 => N! = 3628800 => 2
	//N = 20 => N! = 2432902008176640000 => 4
	//Does your program work for N = 50 000?
	//Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!

class TrailingZeroes
{
	static void Main ()
	{
		Console.Write ( "Enter N: " );
		int N = int.Parse ( Console.ReadLine () );	

		int count = 0;
		for (int i = 5; 1 <= (N / i); i *= 5)
		{
			count += N / i;
		}
		Console.WriteLine (count);
	}
}

