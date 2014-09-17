using System;

// Write an expression that calculates trapezoid's area by given sides a and b and height h.

class TapezoidArea
	{
	static void Main()
		{
			Console.WriteLine("This program calculates trapezoid's area.");
			Console.Write("Side a = ");
			double a = double.Parse(Console.ReadLine());
			Console.Write("Side b = ");
			double b = double.Parse(Console.ReadLine());
			Console.Write("hight = ");
			double height = double.Parse(Console.ReadLine());
			double area = ((a + b) / 2) * height;
			Console.WriteLine("The area is {0}.", area);
		}
	}

