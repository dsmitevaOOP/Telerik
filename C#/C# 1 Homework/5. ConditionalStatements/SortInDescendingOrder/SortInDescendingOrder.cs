using System;

//Sort 3 real values in descending order using nested if statements.

class SortInDescendingOrder
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double first = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double second = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double third = double.Parse(Console.ReadLine());

        if (third < second)
        {
            if (first < third)
            {
                Console.WriteLine("The descending order of the number is: {0}, {1}, {2}.", second, third, first);
            }
            else
            {
                if (first > second)
                {
                    Console.WriteLine("The descending order of the number is: {0}, {1}, {2}.", first, second, third);
                }
                else
                {
                    Console.WriteLine("The descending order of the number is: {0}, {1}, {2}.", second, first, third);
                }
            }
        }
        else
        {
            if (first < second)
            {
                Console.WriteLine("The descending order of the number is: {0}, {1}, {2}.", third, second, first);
            }
            else
            {
                if (first > third)
                {
                    Console.WriteLine("The descending order of the number is: {0}, {1}, {2}.", first, third, second);
                }
                else
                {
                    Console.WriteLine("The descending order of the number is: {0}, {1}, {2}.", third, first, second);
                }
            }
        }
    }
}

