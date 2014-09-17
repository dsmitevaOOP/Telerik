using System;
using System.Globalization;

	class BeerTime
	{
		static void Main ()
		{
			string input = Console.ReadLine ();
			DateTime user = DateTime.Parse ( input);
			int h = user.Hour;
			if ((user.Hour >= 13 && user.Hour <= 24) || user.Hour < 3)
			{
				Console.WriteLine ("beer time");
			}
			else
			{
				Console.WriteLine ("non - beer time");
			}
		}
	}
