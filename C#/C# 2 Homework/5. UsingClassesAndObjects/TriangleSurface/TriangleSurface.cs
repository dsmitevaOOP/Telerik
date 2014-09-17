using System;

// Write methods that calculate the surface of a triangle by given:
//	Side and an altitude to it; 
//	Three sides; 
//	Two sides and an angle between them. 
// Use System.Math.

class TriangleSurface
{
	static double SideAltitude ( double side, double alt )
	{
		return (side * alt) / 2;
	}

	static double ThreeSides ( double a, double b, double c )
	{
		double p = (a + b + c) / 2;
		double surface = Math.Sqrt ( p * (p - a) * (p - b) * (p - c) );
		return surface;
	}

	static double TwoSidesAngle ( double a, double b, double alpha )
	{
		return (a * b * Math.Sin ( Math.PI * alpha / 180 )) / 2;
	}

	static void Main ()
	{
		Console.WriteLine ( "How do you want to find triangle's surface: " );
		Console.WriteLine ( "By given side and altitude to it: press 1" );
		Console.WriteLine ( "By given three sides: press 2" );
		Console.WriteLine ( "By given two sides and an angle between them: press 3" );

		int choice = int.Parse ( Console.ReadLine () );

		switch (choice)
		{
			case 1:
				Console.Write ("Enter side: ");
				double side = double.Parse (Console.ReadLine());
				Console.Write ("Enter altitude: ");
				double altitude = double.Parse (Console.ReadLine());
				double resFirstCase = SideAltitude ( side, altitude );
				Console.WriteLine (resFirstCase);
				break;
			case 2:
				Console.Write ("Enter side: ");
				double f = double.Parse (Console.ReadLine());
				Console.Write ("Enter side: ");
				double s = double.Parse ( Console.ReadLine () );
				Console.Write ("Enter side: ");
				double t = double.Parse (Console.ReadLine());
				double resSecCase = ThreeSides (f, s, t);
				Console.WriteLine ( resSecCase );
				break;
			case 3:
 				Console.Write ("Enter side: ");
				double first = double.Parse (Console.ReadLine());
				Console.Write ("Enter side: ");
				double sec = double.Parse ( Console.ReadLine () );
				Console.Write ("Enter angle: ");
				double alpha = double.Parse (Console.ReadLine());
				double resThirdCase = TwoSidesAngle (first, sec, alpha);
				Console.WriteLine ( resThirdCase );
				break;
		}
	}
}

