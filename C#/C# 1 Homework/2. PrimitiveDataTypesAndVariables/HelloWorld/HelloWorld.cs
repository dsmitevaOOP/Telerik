﻿using System;

// Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

class HelloWorld
	{
	static void Main()
		{
			string hello = "Hello,";
			string world = "World";
			object helloWorld = hello + " " + world;
			string myString = (string) helloWorld;
			Console.WriteLine("{0}\n{1}\n{2}\n{3}", hello, world, helloWorld, myString);
		}
	}

