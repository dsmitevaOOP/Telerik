using System;

//Write a program that reads the radius r of a circle and prints its perimeter and area.

class CirclePerimeterArea
	{
	static void Main()
		{
			Console.Write("Enter the radius if the circle: ");
			double rad = double.Parse(Console.ReadLine());
			double per = 2 * Math.PI * rad;
			double area = Math.PI * Math.Pow(rad, 2);
			Console.WriteLine("The perimeter of the circle is {0:0.00} \n and the area of the circle is {1: 0.00}.", per, area);
		}
	}

