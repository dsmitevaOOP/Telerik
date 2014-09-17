using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
	class BullsAndCows
	{
		static void Main ( string[] args )
		{
			string secret = Console.ReadLine ();

			int bulls = int.Parse ( Console.ReadLine () );
			int cows = int.Parse ( Console.ReadLine () );

			int bullsCount = 0;
			int cowsCount = 0;

			bool hasZero = false;
			bool noOutput = true;

			char[] secretDig = secret.ToCharArray();

			for (int num = 1111; num <= 9999; num++)
			{
				hasZero = false;
				secretDig = secret.ToCharArray();

				char[] temp = num.ToString ().ToCharArray ();

				for (int i = 0; i < temp.Length; i++)
				{
					if (temp[i] == '0')
					{
						hasZero = true;
					}
				}

				if (hasZero == true)
				{
					continue;
				}

				for (int j = 0; j < secretDig.Length; j++)
				{
					for (int k = 0; k < temp.Length; k++) // bulls
					{
						if ((secretDig[j] == temp[k]) && (j == k))
						{
							bullsCount++;
							secretDig[j] = '0';
							temp[k] = '0';
						}
					}
				}

				for (int j = 0; j < secretDig.Length; j++)
				{
					for (int k = 0; k < temp.Length; k++) // cows
					{
						if ((secretDig[j] == temp[k]) && (j != k) && (secretDig[j] != '0') && (temp[k] != '0'))
						{
							cowsCount++;
							secretDig[j] = '0';
							temp[k] = '0';
						}
					}
				}
				

				if(bulls == bullsCount && cows == cowsCount)
				{
					Console.Write(num + " ");
					noOutput = false;
				}

				bullsCount = 0;
				cowsCount = 0;
			}

			if (noOutput == true)
			{
				Console.WriteLine("No");
			}
		}
	}
}
