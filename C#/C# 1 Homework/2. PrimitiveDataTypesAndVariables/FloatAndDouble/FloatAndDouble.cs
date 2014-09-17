using System;

class FloatandDouble
	{
	static void Main()
		{
			//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023,			12.345, 8923.1234857, 3456.091?
			float myFloat1 = 12.345f;
			float myFloat2 = 3456.091f;
			double myDouble1 = 34.567839023;
			double myDouble2 = 8923.1234857;
			Console.WriteLine("{0} is float\n{1} is float\n{2} is double\n{3} is double", myFloat1, myFloat2, myDouble1, myDouble2);
		}
	}