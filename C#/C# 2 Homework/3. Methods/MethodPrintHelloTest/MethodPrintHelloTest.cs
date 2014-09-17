using System;
using System.Linq;

//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

class MethodPrintHelloTest
{
	static void Ask()
	{
		Console.WriteLine ("Enter some name: ");
	}

	static void TestAndPrint (string my)
	{
		if (Test(my))
		{
			Console.WriteLine ( "Hello, {0}", my );
		}
		else
		{
			Console.WriteLine ( "Invalid name !" );
		}
	}

	static bool Test ( string str )
	{
		bool result = str.All ( Char.IsLetter );
		return result;
	}

	static void Main ()
	{
		Ask ();
		TestAndPrint (Console.ReadLine());
	}
}

