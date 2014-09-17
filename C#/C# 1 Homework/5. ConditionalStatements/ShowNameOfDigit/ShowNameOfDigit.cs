using System;

//Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

class ShowNameOfDigit
{
	public enum Digits 
	{ 
		Zero, 
		One, 
		Two, 
		Three, 
		Four, 
		Five, 
		Six, 
		Seven, 
		Eight, 
		Nine 
	};

	static void Main()
	{
		Console.Write("Enter a digit: ");
		int input = int.Parse (Console.ReadLine());
		Digits dig = (Digits) input;
		switch (input)
		{
			case (int) Digits.Zero: 
			case (int) Digits.One: 
			case (int) Digits.Two: 
			case (int) Digits.Three: 
			case (int) Digits.Four:
			case (int) Digits.Five: 
			case (int) Digits.Six: 
			case (int) Digits.Seven: 
			case (int) Digits.Eight: 
			case (int) Digits.Nine: 
				Console.WriteLine (dig);
				break;
			default: 
				Console.WriteLine ("Incorrect input!!!");
				break;
		}
	}
}

