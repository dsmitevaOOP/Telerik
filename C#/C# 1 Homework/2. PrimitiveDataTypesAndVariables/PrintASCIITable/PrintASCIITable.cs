using System;
using System.Text;

//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console.

class PrintASCIITable
	{
	static void Main()
		{
			for (int i = 0; i < 255; i++)
				{
					Console.OutputEncoding = Encoding.ASCII; 
					Console.Write((char) i + " ");
				}
		}
	}

