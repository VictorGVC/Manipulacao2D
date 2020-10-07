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
					b.SetPixel((x1 + x * fator), (int)Math.Round(y), Color.Black);
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
					b.SetPixel((int)Math.Round(x), (y1 + y * fator), Color.Black);
				}
			}
			catch
			{ }
		}

		public static void BresenhamLow(int x1, int y1, Bitmap b, double dx, double dy,int fx,int fy)
		{
			int incE, incNE, d;
			incE = (int)(2 * dy);
			incNE = (int)(2 * dy - 2 * dx);
			d = (int)(2 * dy - dx);

			try
			{
				for (int x = 0; x < dx; x++)
				{
					b.SetPixel(x1 + x * fx, y1 , Color.Black);

					if (d > 0)
					{
						y1 = y1 + fy;
						d += incNE;
					}
					else
						d += incE;
				}
			}
			catch (Exception)
			{ }

		}

		public static void BresenhamHigh(int x1, int y1, Bitmap b, double dx, double dy,int fx,int fy)
		{
			int  incE, incNE, d;
			incE = (int)(2 * dx);
			incNE = (int)(2 * dx - 2 * dy);
			d = (int)(2 * dx - dy);

			for (int y = 0; y < dy; y++)
			{
                try
                {
					b.SetPixel(x1, y1 + y * fy, Color.Black);
				}
                catch (Exception)
                {
                }
					

				if (d > 0)
				{
					x1 = x1 + fx;
					d += incNE;
				}
				else
					d += incE;
			}
			
		}
    }
}
