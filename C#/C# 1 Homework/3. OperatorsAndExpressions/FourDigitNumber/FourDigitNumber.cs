using System;

	class FourDigitNumber
	{
		static void Main ()
		{
			Console.Write ("Enter some four - digit number: ");
			string textNumber = Console.ReadLine ();
			int number = int.Parse (textNumber);

			int sum = int.Parse ( textNumber[0].ToString() ) + int.Parse ( textNumber[1].ToString() ) + int.Parse ( textNumber[2].ToString() ) + int.Parse ( textNumber[3].ToString() );

			Console.WriteLine (sum);

			for (int i = 3; i >= 0; i--)
			{
				Console.Write (textNumber[i]);
			}
			Console.WriteLine ();

			Console.Write (textNumber[3]);
			for (int i = 0; i < 3; i++)
			{
				Console.Write ( textNumber[i] );
			}
			Console.WriteLine ();

			Console.Write ("{0}{1}{2}{3} \n", textNumber[0], textNumber[2], textNumber[1], textNumber[3]);
		}
	}

