using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpression
{
	class MathExpression
	{
		static void Main ( string[] args )
		{
			double n = double.Parse ( Console.ReadLine () );
			double m = double.Parse ( Console.ReadLine () );
			double p = double.Parse ( Console.ReadLine () );
			double tempRes = 0;

			double res1 = n * n;
			tempRes = m * p;
			tempRes = 1 / tempRes;
			res1 = res1 + tempRes;
			res1 = res1 + 1337;

			double res2 = 128.523123123 * p;
			res2 = -1 * res2;
			res2 = n + res2;

			double res = res1 / res2;

			double res3 = (int) m % 180;
			res3 = Math.Sin ( res3 );

			res = res + res3;

			Console.WriteLine ( "{0:0.000000}", res );
		}
	}
}
