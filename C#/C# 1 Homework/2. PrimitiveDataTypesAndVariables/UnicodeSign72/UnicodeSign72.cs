using System;

//Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

class UnicodeSign72
	{
	static void Main()
		{
			char myChar = '\u0048';
			Console.WriteLine(myChar);

			// This is another way of assigning charachter when you know the code. It is done by type casting from int type to char type

			myChar = (char) 72;
			Console.WriteLine(myChar);
		}
	}

