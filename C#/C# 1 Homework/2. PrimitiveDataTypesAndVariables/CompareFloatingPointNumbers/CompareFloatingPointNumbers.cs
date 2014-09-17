using System;


class CompareFloatingPointNumbers
	{
	static void Main()
		{
			double num1, num2;
			Console.Write("Enter a number: ");

			// Here I am using System.Globalization.CultureInfo.GetCultureInfo("en-US") to unify the decimal symbol. If your regional settings			are	bulgarian and you put "." for decimal symbol and you don't have CultureInfo your program will throw an exception. But when this			function is included it won't. 

			num1 = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
			Console.Write("Enter another number: ");
			num2 = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
			double absSubstrac = Math.Abs(num1 - num2);

			// Here I define that if the quotient of the two numbers is less than 0.0000001 then the digits after the decimal symbol from the			seventh position onwards are unimportant for us. That is done because we want 6 digit percision after the decimal sign. For ex.				if you	have 5.00000003 and 5.0000000003 the result will be true because 0.0000000297 is less than 0.0000001. Also if the					numbers have for ex. 3 signs after the decimal symbol and the numbers are the same then their quotient is 0 which is also less than			0.0000001. In any other case they are different and the result is false.

			if (absSubstrac < 0.0000001)
				{
					Console.WriteLine("true");
				}
			else
				{
					Console.WriteLine("false");
				}
		}
	}

