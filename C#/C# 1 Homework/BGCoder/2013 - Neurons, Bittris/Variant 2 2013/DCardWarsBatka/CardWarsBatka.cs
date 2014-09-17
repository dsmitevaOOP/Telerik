using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CardWarsBatka
{
	class CardWarsBatka
	{
		static void Main ( string[] args )
		{
			int n = int.Parse ( Console.ReadLine () );

			int fph = 0;
			int sph = 0;
			BigInteger fps = 0;
			BigInteger sps = 0;
			bool firstX = false;
			bool secondX = false;
			bool res = false;
			int gameF = 0;
			int gameS = 0;

			for (int i = 1; i <= n; i++)
			{
				fph = 0;
				sph = 0;
				firstX = false;
				secondX = false;
				res = false;
				string[] firstPlayerCards = new string[3];
				string[] secondPlayerCards = new string[3];

				for (int j = 0; j < firstPlayerCards.Length; j++)
				{
					firstPlayerCards[j] = Console.ReadLine ();

					if (firstPlayerCards[j][0] == '-')
					{
						continue;
					}

					switch (firstPlayerCards[j])
					{
						case "A":
							fph = fph + 1;
							break;
						case "10":
							fph = fph + 2;
							break;
						case "9":
							fph = fph + 3;
							break;
						case "8":
							fph = fph + 4;
							break;
						case "7":
							fph = fph + 5;
							break;
						case "6":
							fph = fph + 6;
							break;
						case "5":
							fph = fph + 7;
							break;
						case "4":
							fph = fph + 8;
							break;
						case "3":
							fph = fph + 9;
							break;
						case "2":
							fph = fph + 10;
							break;
						case "J":
							fph = fph + 11;
							break;
						case "Q":
							fph = fph + 12;
							break;
						case "K":
							fph = fph + 13;
							break;
						case "Z":
							fps = fps * 2;
							break;
						case "Y":
							fps = fps - 200;
							break;
						case "X":
							firstX = true;
							break;
					}
				}

				for (int j = 0; j < secondPlayerCards.Length; j++)
				{
					secondPlayerCards[j] = Console.ReadLine ();

					if (secondPlayerCards[j][0] == '-')
					{
						continue;
					}

					switch (secondPlayerCards[j])
					{
						case "A":
							sph = sph + 1;
							break;
						case "10":
							sph = sph + 2;
							break;
						case "9":
							sph = sph + 3;
							break;
						case "8":
							sph = sph + 4;
							break;
						case "7":
							sph = sph + 5;
							break;
						case "6":
							sph = sph + 6;
							break;
						case "5":
							sph = sph + 7;
							break;
						case "4":
							sph = sph + 8;
							break;
						case "3":
							sph = sph + 9;
							break;
						case "2":
							sph = sph + 10;
							break;
						case "J":
							sph = sph + 11;
							break;
						case "Q":
							sph = sph + 12;
							break;
						case "K":
							sph = sph + 13;
							break;
						case "Z":
							sps = sps * 2;
							break;
						case "Y":
							sps = sps - 200;
							break;
						case "X":
							secondX = true;
							break;
					}
				}

				res = firstX && secondX;

				if (res)
				{
					fps = fps + 50;
					sps = sps + 50;
				}

				if (firstX == true && res == false)
				{
					Console.WriteLine ( "X card drawn! Player one wins the match!" );
					return;
				}

				if (secondX == true && res == false)
				{
					Console.WriteLine ( "X card drawn! Player two wins the match!" );
					return;
				}

				if (fph > sph)
				{
					fps = fps + fph;
					gameF++;
				}

				if (sph > fph)
				{
					sps = sps + sph;
					gameS++;
				}
			}

			if (fps > sps)
			{
				Console.WriteLine ( "First player wins!" );
				Console.WriteLine ( "Score: {0}", fps );
				Console.WriteLine ( "Games won: {0}", gameF );
			}

			if (sps > fps)
			{
				Console.WriteLine ( "Second player wins!" );
				Console.WriteLine ( "Score: {0}", sps );
				Console.WriteLine ( "Games won: {0}", gameS );
			}


			if (fps == sps)
			{
				Console.WriteLine ( "It's a tie!" );
				Console.WriteLine ( "Score: {0}", fps );
			}
		}
	}
}
