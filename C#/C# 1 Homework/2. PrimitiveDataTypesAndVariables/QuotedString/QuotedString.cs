using System;

// Declare two string variables and assign them with following value:																		The "use" of quotations causes difficulties.																									 Do the above in two different ways: with and without using quoted strings.

class QuotedString
	{
	static void Main()
		{
			string escape = "The \"use\" of quotation causes difficulties";
			string quoted = @"The ""use"" of quotation causes difficulties";
			Console.WriteLine("{0}\n{1}", escape, quoted);
		}
	}

