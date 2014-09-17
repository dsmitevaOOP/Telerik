using System;

//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

class IsThirdDigit7
	{
	static void Main()
		{
			Console.WriteLine("The program checks for a given integer if the third digit (right to left) is 7.");
			Console.Write("Enter number: ");
			int number = int.Parse(Console.ReadLine());
			bool result = false;
			if (number >= 700)
				{
					int checkThird = (number / 100) % 10;
					result = checkThird == 7 ? true : false;
				}
			Console.WriteLine("Is the third digit 7? \n{0}", result); 
		}
	}

