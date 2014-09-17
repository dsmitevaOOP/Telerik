using System;

//Write a program that finds the biggest of three integers using nested if statements.

class BiggestInteger
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int third = int.Parse(Console.ReadLine());

        if (second > third)
        {
            if (first > second)
            {
                Console.WriteLine("The biggest integer is {0}.", first);
            }
            else
            {
                Console.WriteLine("The biggest integer is {0}.", second);
            }
        }
        else
        {
            if (first > third)
            {
                Console.WriteLine("The biggest integer is {0}.", first);
            }
            else
            {
                Console.WriteLine("The biggest integer is {0}.", third);
            }
        }
    }
}

