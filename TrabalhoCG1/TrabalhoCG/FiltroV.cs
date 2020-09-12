using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCG
{
    class FiltroV
    {
        public static void EqGeralRetaQ1(double m, int x1, int y1, double dx, Bitmap b, int fator)
        {
			try
			{
				for (int x = 0; x <= dx; x++)
				{
					double y = y1 + m * ((x1+x*fator) - x1);
					b.SetPixel((x1 + x * fator), (int)Math.Round(y), Color.Gray);
				}
			}
			catch
			{ }
		}

		public static void EqGeralRetaQ2(double m, int x1, int y1, double dy, Bitmap b, int fator)
		{
			try
			{
				for (int y = 0; y <= dy; y++)
				{
					double x = x1 + ((y1 + y * fator) - y1)/m;
					b.SetPixel((int)Math.Round(x), (y1 + y * fator), Color.Gray);
				}
			}
			catch
			{ }
		}
	}
}
