using System;

//We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n. Example: n = 5 (00000101), p=3, v=1 --> 13 (00001101) n = 5 (00000101), p=2, v=0 --> 1 (00000001)

class ModifyBit
	{
	static void Main()
		{
			Console.Write("Enter some integer: ");
			int myInt = int.Parse(Console.ReadLine());
			Console.Write("Enter the position of the bit to be modified: ");
			int pos = int.Parse(Console.ReadLine());
			Console.Write("Enter value: ");
			int value = int.Parse(Console.ReadLine());
			if (value != 0 || value != 1)
				{ 
				while (value != 0 && value != 1)
					{
						Console.WriteLine("Incorrect input!");
						Console.Write("Enter value: ");
						value = int.Parse(Console.ReadLine());
					}
				}
			
			Console.WriteLine(Convert.ToString(myInt, 2).PadLeft(32, '0'));

			if (value == 1)
			{
				int mask = 1 << pos;
				int result = myInt | mask;
				Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));	
			}
			else
			{
				int mask = ~(1 << pos);
				int result = myInt & mask;
				Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
			}
		}
	}

