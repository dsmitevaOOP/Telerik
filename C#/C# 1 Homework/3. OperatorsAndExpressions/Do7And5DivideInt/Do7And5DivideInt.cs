using System;

//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

class Do7And5DivideInt
	{
	static void Main()
		{
			Console.WriteLine("The program checks if an integer can be divided without remainder by 7 and 5 in the same time.");
			Console.Write("Enter some integer = ");
			int myInt = int.Parse(Console.ReadLine());
			if (myInt % 7 == 0 && myInt % 5 == 0 && myInt != 0)
			{
				bool result = true;
				Console.WriteLine("{0}", result);
			}
			else
			{
				bool result = false;
				Console.WriteLine("{0}", result);
			}
		}
	}

