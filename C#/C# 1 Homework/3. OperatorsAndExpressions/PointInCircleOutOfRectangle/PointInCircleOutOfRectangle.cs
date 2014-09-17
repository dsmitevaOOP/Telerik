using System;

//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

class PointInCircleOutOfRectangle
	{
	static void Main()
		{
			double center = 1;
			double rad = 1.5;
			double width = 6;
			double height = 2;
			double topLeftX = -1;
			double topLeftY = 1;

 			Console.WriteLine("The program checks if given point (x, y) is within a circle K((1, 1), 1.5) and out of Rectangle R(Top-Left(1, -1), width = 6; height = 2");

			Console.Write("x = ");
			double x = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));

			Console.Write("y = ");
			double y = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));

			double distCircle = Math.Sqrt(Math.Pow((x - center), 2) + Math.Pow((y - center), 2)); //Calculates the distance between the point P(x, y) and the centre of the circle
			bool resultCircle = distCircle <= rad ? true : false; // The points on the circle itself are also included

			bool resultRec = true;

			if (x >= -1 && x <= 5 && y <= 1 && y >= -1)
			{
				resultRec = false;
			}

			bool result = resultCircle && resultRec;
			Console.WriteLine (result);
		}
	}


