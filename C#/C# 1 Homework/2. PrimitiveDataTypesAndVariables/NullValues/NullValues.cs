using System;

//Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

class NullValues
	{
	static void Main()
		{
			int? nullInt = null;
			double? nullDouble = null;
			Console.WriteLine("This variable has type int and value null: {0}\nand this variable has type double and value null: {1} \n", 
			nullInt, nullDouble);
			nullInt = 5;
			nullDouble = 10;
			Console.WriteLine("This variable has type int ant value 5: {0}\nand this variable has type double and value 10: {1} \n",
			nullInt, nullDouble);
		}
	}

