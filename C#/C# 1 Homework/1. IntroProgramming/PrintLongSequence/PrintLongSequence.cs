﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
	class PrintLongSequence
	{
		static void Main ()
		{
			int member = 2;
			int count = 0;

			//Here I use if...else statement in while loop. The if...else statement checks if the number is odd or even so it could define t			hesign. Iuse the while loop to restrict the result to the first 10 members. For this purpose I use the variable count. Its default			value is 0 and this means that the tenth member of the sequence will have index 9. That is why the variable count should be less			than 10, because if it is less or even to 10 it will print the eleventh memebr also. I can also write "count <= 9" - that is the			same as "count < 10". 

			while (count < 1000)
			{
				if (member % 2 == 0)
				{
					Console.Write ( member + "," );
				}
				else
				{
					Console.Write ( -member + "," );
				}
				member++;
				count++;
			}
		}
	}
}
