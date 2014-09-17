using System;

//Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
//0 => "Zero"
//273 => "Two hundred seventy three"
//400 => "Four hundred"
//501 => "Five hundred and one"
//711 => "Seven hundred and eleven"

class NumbersToText
{
	public enum Digit
	{
		Zero = 0, One, Two, Three, Four, Five, Six, Seven, Eight, Nine
	}

	public enum Ten
	{
		Ten = 10, Eleven, Twelve, Thirteen, Fourteen, Fifteen, Sixteen, Seventeen, Eighteen, Nineteen
	}

	public enum Ty
	{
		Ten = 1, Twenty = 2, Thirty, Fourty, Fifty, Sixty, Seventy, Eighty, Ninety
	}
	static void Main ()
	{
		Console.Write ( "Enter number [0...999]: " );
		int input = int.Parse ( Console.ReadLine () );

		while (!((input >= 0) && (input < 1000)))
		{
			Console.Write ( "Incorrect input!!! \nEnter number [0...999]: " );
			input = int.Parse ( Console.ReadLine () );
		}

		while ((input >= 0) && (input < 1000))
		{
			if ((input >= 0) && (input < 10))
			{
				Digit someDigit = (Digit) input;
				Console.WriteLine ( someDigit );
			}

			if ((input > 9) && (input < 20))
			{
				Ten someTen = (Ten) input;
				Console.WriteLine ( someTen );
			}

			if ((input > 19) && (input < 100))
			{
				Ty someTy = (Ty) (input / 10);
				Digit someDigit = (Digit) (input % 10);

				if (someDigit != 0)
				{
					switch (someTy)
					{
						case Ty.Twenty:
						case Ty.Thirty:
						case Ty.Fourty:
						case Ty.Fifty:
						case Ty.Sixty:
						case Ty.Seventy:
						case Ty.Eighty:
						case Ty.Ninety:
							Console.WriteLine ( someTy + " " + someDigit );
							break;
					}
				}
				else
				{
					Console.WriteLine ( someTy );
				}
			}

			if ((input > 99) && (input < 1000))
			{
				Digit someHund = (Digit) (input / 100);
				Ty someTy = (Ty) ((input % 100) / 10);
				Digit someDigit = (Digit) (input % 10);
				Ten someTen = (Ten) (input % 100);

				if ((someTy != 0) && (someTy != Ty.Ten) && (someDigit != Digit.Zero))
				{
					switch (someHund)
					{
						case Digit.One:
						case Digit.Two:
						case Digit.Three:
						case Digit.Four:
						case Digit.Five:
						case Digit.Six:
						case Digit.Seven:
						case Digit.Eight:
						case Digit.Nine:
							Console.WriteLine ( someHund + " Hundred " + someTy + " " + someDigit );
							break;
					}
				}
				else if ((someTy == 0) && (someDigit == 0))
				{
					Console.WriteLine ( someHund + " Hundred" );
				}
				else if ((someTy == 0) && (someDigit != 0))
				{
					Console.WriteLine ( someHund + " Hundred and " + someDigit );
				}
				else if ((someTen >= Ten.Ten) && (someTen <= Ten.Nineteen))
				{
					Console.WriteLine ( someHund + " Hundred and " + someTen );
				}
				else
				{
					Console.WriteLine ( someHund + " Hundred and " + someTy );
				}
			}

			Console.Write ( "Enter number [0...999]: " );
			input = int.Parse ( Console.ReadLine () );

			while (!((input >= 0) && (input < 1000)))
			{
				Console.Write ( "Incorrect input!!! \nEnter number [0...999]: " );
				input = int.Parse ( Console.ReadLine () );
			}
		}
	}
}

