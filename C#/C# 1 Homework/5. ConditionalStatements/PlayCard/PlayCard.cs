using System;

class PlayCard
{
	static void Main ()
	{
		string input = Console.ReadLine ();
		int res;
		bool my = Int32.TryParse ( input, out res );

		if (my && res > 1 && res < 11)
		{
			for (int i = 2; i < 11; i++)
			{
				if (res == i)
				{
					Console.WriteLine ( "Yes" );
				}
			}
		}
		else
		{
			if (input == "J" || input == "Q" || input == "K" || input == "A")
			{
				Console.WriteLine ( "Yes" );
			}
			else
			{
				Console.WriteLine ( "No" );
			}
		}
	}
}
