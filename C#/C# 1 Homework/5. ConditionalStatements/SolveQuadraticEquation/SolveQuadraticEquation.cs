using System;

//Write a program that enters the coefficients a, b and c of a quadratic equation
//				a*x2 + b*x + c = 0
//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

class SolveQuadraticEquation
{
	static void Main ()
	{
		Console.Write ( "Enter coefficient \"a\": " );
		double a = double.Parse ( Console.ReadLine () );

		Console.Write ( "Enter coefficient \"b\": " );
		double b = double.Parse ( Console.ReadLine () );

		Console.Write ( "Enter coefficient \"c\": " );
		double c = double.Parse ( Console.ReadLine () );

		double not = 0;

		if (a == 0)
		{
			Console.WriteLine ( "The equation is not quadratic!!!" );
			not = (c * (-1)) / b;
			Console.WriteLine ( "It's root is {0}", not );
		}
		else
		{
			double dis = Math.Pow ( b, 2 ) - (4 * a * c);

			if (dis < 0)
			{
				Console.WriteLine ( "The equoation has no real roots!" );
			}
			else if (dis == 0)
			{
				double x0 = (-b) / (2 * a);
				Console.WriteLine ( "The equation has one real root: {0}", x0 );
			}
			else
			{
				double x1 = (-b + Math.Sqrt ( dis )) / (2 * a);
				double x2 = (-b - Math.Sqrt ( dis )) / (2 * a);
				Console.WriteLine ( "The equation has two real roots: {0} and {1}.", x1, x2 );
			}
		}
	}
}

