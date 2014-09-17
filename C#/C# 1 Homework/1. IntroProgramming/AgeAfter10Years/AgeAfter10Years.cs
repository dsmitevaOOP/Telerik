using System;

//Write a program to read your age from the console and print how old you will be after 10 years.

class AgeAfter10Years
	{
	static void Main()
		{
			Console.WriteLine("What is your age?");

			//The Console reads and returns only string. That is why if we want to work with numbers we should convert them first. Here that			is done with the parse function. The program reads the input and converts it to int. If we don't convert it to int we wouldn't be			able to do any calculations because the compiler thinks it is text. If you don't parse it you will have a compilaltion error which			says that string type cannot be implicitly convert to int type. 

			int Age = int.Parse(Console.ReadLine());
			Age = Age + 10;
			Console.WriteLine(Age);
		}
	}


