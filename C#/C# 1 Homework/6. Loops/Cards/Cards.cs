using System;

//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.

class Cards
{
	public enum Card {Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }

	public enum Suits {Hearts = 1, Diamonds, Spades, Clubs }
	static void Main ()
	{
		for (int i = 1; i <= 4; i++)
		{
			Suits someSuit = (Suits) i;
			switch (someSuit)
			{
				case Suits.Hearts:
				case Suits.Diamonds:
				case Suits.Spades:
				case Suits.Clubs:
					Console.Write ( "" );
					break;
			}
			for (int j = 1; j <= 13; j++)
			{
				Card someCard = (Card) j;
				switch (someCard)
				{
					case Card.Ace:
					case Card.Two:
					case Card.Three:
					case Card.Four:
					case Card.Five:
					case Card.Six:
					case Card.Seven:
					case Card.Eight:
					case Card.Nine:
					case Card.Ten:
					case Card.Jack:
					case Card.Queen:
					case Card.King:
						Console.Write (someSuit + " " + someCard + " \n");
						break;
				}
			}
		}
	}
}

