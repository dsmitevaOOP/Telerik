using System;
using System.Text; // Encoding.UTF8 is her

//Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.

class TheCopyrightSymbol
	{
	static void Main()
		{
			char copyRight = '©';
			Console.OutputEncoding = Encoding.UTF8; // Without this line the result won't be printed corectly on the console. If it is still													printed	wrong try changing the font to Lucida Console or Consolas.
			Console.WriteLine(@"
    {0}
   {0} {0}
  {0}   {0}
 {0} {0} {0} {0}", copyRight);

		}
	}

