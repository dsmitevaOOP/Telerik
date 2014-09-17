using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
	class CofeeMachine
	{
		static void Main ( string[] args )
		{
			double N1 = double.Parse ( Console.ReadLine () );
			double N2 = double.Parse ( Console.ReadLine () );
			double N3 = double.Parse ( Console.ReadLine () );
			double N4 = double.Parse ( Console.ReadLine () );
			double N5 = double.Parse ( Console.ReadLine () );
			double amount = double.Parse ( Console.ReadLine () );
			double price = double.Parse ( Console.ReadLine () );
			double sum = (N1 * 0.05) + (N2 * 0.1) + (N3 * 0.2) + (N4 * 0.5) + N5;

			if (amount < price)
			{
				Console.WriteLine ( "More {0:0.00}", (price - amount) );
			}
			else if ((amount > price) && (sum < (amount - price)))
			{
				Console.WriteLine ( "No {0:0.00}", (amount - price - sum) );
			}
			else if ((amount > price) && (sum > (amount - price)))
			{
				Console.WriteLine ( "Yes {0:0.00}", (sum - (amount - price)) );
			}
			else if (amount == price)
			{
				Console.WriteLine ("Yes {0:0.00}", sum);	
			}
		}
	}
}
