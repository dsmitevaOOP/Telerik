using System;

//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

class SignProduct
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int third = int.Parse(Console.ReadLine());

		if (first == 0 || second == 0 || third == 0)
		{
			Console.WriteLine ("The product is zero");
			return;
		}

        bool greaterThanZero = (first > 0) && (second > 0);
        bool smallerThanZero = (first < 0) && (second < 0);

        if (greaterThanZero || smallerThanZero)
        {
            if (third < 0)
            {
                Console.WriteLine("The product is negative!");
            }
            else if (third > 0)
            {
                Console.WriteLine("The product is positive!");
            }
        }
        else if (third > 0)
        {
            if (third < 0)
            {
                Console.WriteLine("The product is positive!");
            }
            else if (third > 0)
            {
                Console.WriteLine("The product is negative!");
            }
        }
    }
}

