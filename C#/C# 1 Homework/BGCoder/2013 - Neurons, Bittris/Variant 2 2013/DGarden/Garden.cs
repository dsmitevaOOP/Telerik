using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
	class Garden
	{
		static void Main ( string[] args )
		{
			int seedsTomato = int.Parse ( Console.ReadLine () );
			int areaTomato = int.Parse ( Console.ReadLine () );

			int seedsCucumber = int.Parse ( Console.ReadLine () );
			int areaCucumber = int.Parse ( Console.ReadLine () );

			int seedsPotato = int.Parse ( Console.ReadLine () );
			int areaPotato = int.Parse ( Console.ReadLine () );

			int seedsCarrot = int.Parse ( Console.ReadLine () );
			int areaCarrot = int.Parse ( Console.ReadLine () );

			int seedsCabbage = int.Parse ( Console.ReadLine () );
			int areaCabbage = int.Parse ( Console.ReadLine () );

			int seedsBeans = int.Parse ( Console.ReadLine () );

			double price =
				seedsTomato * 0.5 + (seedsCucumber + seedsBeans) * 0.4 + seedsPotato * 0.25 + seedsCarrot * 0.6 + seedsCabbage * 0.3;

			int area = 250 - areaTomato - areaCucumber - areaPotato - areaCarrot - areaCabbage;

			Console.WriteLine ( "Total costs: {0:0.00}", price );

			if (area > 0)
			{
				Console.WriteLine ( "Beans area: {0}", area );
			}

			if (area == 0)
			{
				Console.WriteLine ( "No area for beans" );
			}

			if (area < 0)
			{
				Console.WriteLine ( "Insufficient area" );
			}
		}
	}
}
