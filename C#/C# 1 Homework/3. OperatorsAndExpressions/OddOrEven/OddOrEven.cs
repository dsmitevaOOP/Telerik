using System;

//Write an expression that checks if given integer is odd or even. Да го направя с маска!

class OddOrEven
	{
	static void Main()
		{
			Console.WriteLine("The program checks if an integer is odd or even.");
			Console.Write("Enter Some integer = ");
			int myInt = int.Parse(Console.ReadLine());
			if (myInt % 2 == 0)
				{
					Console.WriteLine("False");
				}
			else
				{
					Console.WriteLine("True");
				}
		}
	}

