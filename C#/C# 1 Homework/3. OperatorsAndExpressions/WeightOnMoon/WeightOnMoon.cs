using System;

	class WeightOnMoon
	{
		static void Main ()
		{
			Console.Write ("Enter weight on Earth: ");
			double weightEarth = double.Parse (Console.ReadLine());

			double weightMoon = (weightEarth * 17) / 100;

			Console.WriteLine ("Your weight on Monn woulld be {0}", weightMoon);
		}
	}

