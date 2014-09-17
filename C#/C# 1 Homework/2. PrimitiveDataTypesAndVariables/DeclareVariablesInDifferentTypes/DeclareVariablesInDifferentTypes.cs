using System;

class DeclareVariablesInDifferentTypes
	{
	static void Main()
		{
			//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long,			ulong to represent the following values: 52130, -115, 4825932, 97, -10000.

			byte myByte = 97;
			sbyte mySbyte = -115;
			short myShort = -10000;
			ushort myUshort = 52130;
			int myInt = 4825932;
			Console.WriteLine("{0} is byte\n{1} is sbyte\n{2} is short\n{3} is ushort\n{4} is int\n", 
			myByte, mySbyte, myShort, myUshort, myInt);
		}
	}

