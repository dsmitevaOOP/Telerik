using System;

	class FormattingNumbers
	{
		static void Main ()
		{
			Console.Write ("Enter integer 0 <= a <= 500: ");
			int a = int.Parse (Console.ReadLine());

			Console.Write ("Enter floating point number: ");
			float b = float.Parse (Console.ReadLine());

			Console.Write ( "Enter floating point number: " );
			float c = float.Parse ( Console.ReadLine () );

			Console.Write ("|");
			Console.Write ("{0,-10:X}", a);
			Console.Write ("|");
			Console.Write (Convert.ToString(a, 2).PadLeft(10, '0'));
			Console.Write ("|");
			Console.Write ("{0,10:0.00}", b);
			Console.Write ("|");
			Console.Write ("{0,-10:0.000}", c);
			Console.Write ("|");
		}
	}
