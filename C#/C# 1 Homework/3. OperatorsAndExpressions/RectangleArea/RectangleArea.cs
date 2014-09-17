using System;

//Write an expression that calculates rectangle’s area by given width and height.

class RectangleArea
	{
	static void Main()
		{
			Console.Write("Enter width of the rectangle: ");
			double width = double.Parse(Console.ReadLine());
			Console.Write("Enter height of the rectangle: ");
			double height = double.Parse(Console.ReadLine());
			double area = width * height;
			double perimimeter = (2 * width) + (2 * height);
			Console.WriteLine ("Rectangle's perimetr is {0}", perimimeter);
			Console.WriteLine ( "Rectangle's area is {0}", area );
		}
	}

