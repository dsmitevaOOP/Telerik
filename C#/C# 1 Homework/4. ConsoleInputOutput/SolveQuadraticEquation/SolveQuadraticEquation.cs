using System;

//Write a program that reads the coefficients a, b and c of a quadratic equation ax^2+bx+c=0 and solves it (prints its real roots).

class SolveQuadraticEquation
	{
	static void Main()
		{
			Console.Write("Enter coefficient \"a\": ");
			double a = double.Parse(Console.ReadLine());
			Console.Write("Enter coefficient \"b\": ");
			double b = double.Parse(Console.ReadLine());
			Console.Write("Enter coefficient \"c\": ");
			double c = double.Parse(Console.ReadLine());
			double dis = Math.Pow(b, 2) - (4 * a * c);
			if (dis < 0)
				{
					Console.WriteLine("The equoation has no real roots!");
				}
			else
				{
					double x1 = (-b + Math.Sqrt(dis)) / (2 * a);
					double x2 = (-b - Math.Sqrt(dis)) / (2 * a);
					Console.WriteLine("The first root is {0} and the second root is {1}.", x1, x2);
				}
			Console.WriteLine ("Press any key to continue ...");
			Console.ReadKey ();
		}
	}

