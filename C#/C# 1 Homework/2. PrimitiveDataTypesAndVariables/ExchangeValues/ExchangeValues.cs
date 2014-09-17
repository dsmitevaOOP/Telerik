using System;

//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

class ExchangeValues
	{
	static void Main()
		{
			int first = 5;
			int second = 10;
			Console.WriteLine("The value of the first variable is {0} \nand the value of the second variable is {1} \n", first,second);
			first = first + second;
			second = first - second;
			first = first - second;
			Console.WriteLine("Now the value of the first variable is {0} \nand the value of the second variable is {1} \n", first, second);
		}
	}

