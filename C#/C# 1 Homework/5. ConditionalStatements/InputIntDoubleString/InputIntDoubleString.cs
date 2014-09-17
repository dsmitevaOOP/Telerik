using System;

//Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.

class InputIntDoubleString
{
	static void Main ()
	{
		Console.Write ("Press 1 for int, 2 for double or 3 for string: ");
		byte choice = byte.Parse (Console.ReadLine());

		switch (choice)
		{
			case 1:
				Console.Write ("Enter some integer: ");
				int intInput = int.Parse(Console.ReadLine ());
				Console.WriteLine ("Your result is: {0}", (intInput + 1));
				break;
			case 2:
				Console.Write ("Enter some real number: ");
				double doubleInput = double.Parse ( Console.ReadLine () );
				Console.WriteLine ("Your result is: {0}", (doubleInput + 1));
				break;
			case 3:
				Console.Write ("Enter some text: ");
				string stringInput = Console.ReadLine ();
				Console.WriteLine ("Your result is: {0}", (stringInput + '*'));
				break;
			default:
				Console.WriteLine ("Incorrect Input!!!");
				break;
		}
	}
}

