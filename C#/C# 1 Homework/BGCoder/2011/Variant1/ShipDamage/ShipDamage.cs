using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipDamage
{
	class ShipDamage
	{
		static void Main ( string[] args )
		{
			int shipX1 = int.Parse ( Console.ReadLine () );
			int shipY1 = int.Parse ( Console.ReadLine () );

			int shipX2 = int.Parse ( Console.ReadLine () );
			int shipY2 = int.Parse ( Console.ReadLine () );

			int minX = Math.Min ( shipX1, shipX2 );
			int maxX = Math.Max ( shipX1, shipX2 );

			int minY = Math.Min ( shipY1, shipY2 );
			int maxY = Math.Max ( shipY1, shipY2 );

			int hor = int.Parse ( Console.ReadLine () );

			int damage = 0;

			for (int i = 1; i <= 3; i++)
			{
				int catX = int.Parse ( Console.ReadLine () );
				int catY = int.Parse ( Console.ReadLine () );

				int pointX = catX;
				int pointY = hor;

				//double dist = Math.Sqrt(Math.Pow (( pointY - catY ), 2));
				//projY = hor + dist// zashto ne raboti?

				int projX = catX;
				int projY = 2 * hor - catY;//works how

				if ((projX > minX) && (projX < maxX) && ((projY == shipY1) || (projY == shipY2)))
				{
					damage += 50;
				}

				if ((projY < maxY) && (projY > minY) && ((projX == shipX1) || (projX == shipX2)))
				{
					damage += 50;
				}

				if (((projX == shipX1) && (projY == shipY1)) || ((projX == shipX1) && (projY == shipY2)) || ((projX == shipX2) && (projY == shipY1)) || ((projX == shipX2) && (projY == shipY2)))
				{
					damage += 25;
				}

				if ((projX > minX) && (projX < maxX) && (projY < maxY) && (projY > minY))
				{
					damage += 100;
				}
			}

			Console.WriteLine (damage + "%");
		}
	}
}
