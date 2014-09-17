using System;

class Reverse
{
	static string Reverse ( string my )
	{
		string temp = "";

		for (int i = my.Length - 1; i > 0; i--)
		{
			temp = temp + my[i];
		}

		return temp;
	}

	static void Main ()
	{
		string some = Console.ReadLine ();
		string res = Reverse ( some );
		Console.WriteLine (res);
	}
}

