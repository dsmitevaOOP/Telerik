using System;

//Write an expression that checks if given point (x,  y) is within a circle K(O, 2).
//Да проверя Math.Pow за корен n - ти

class PointInCircle
{
	static void Main ()
	{
		Console.WriteLine ( "The program checks if given point (x, y) is within a circle K(O, 2)" );
		Console.Write ( "x = " );
		double x = double.Parse ( Console.ReadLine () );
		Console.Write ( "y = " );
		double y = double.Parse ( Console.ReadLine () );
		double distance = Math.Sqrt (Math.Pow(x, 2) + Math.Pow(y, 2));
		bool result;
		if (distance <= 2)
		{
			result = true;
		}
		else
		{
			result = false;
		}
		Console.WriteLine ( "Is the given point within the circle? {0}", result );
	}
}

