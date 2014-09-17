using System;

//Write a method that returns the last digit of given integer as an English word. Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".

class LastIntAsAnEnglWord
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

	static string LastDigit (int my)
	{
		int lastDig = my % 10;
		Digits someDigits = (Digits) lastDig;
		string result = Convert.ToString (someDigits);
		return result;
	}

	static void Main ()
	{
		Console.Write ("Enter some number: ");
		int number = int.Parse (Console.ReadLine());
		string my = LastDigit ( number );
		Console.WriteLine (my);
	}
}

