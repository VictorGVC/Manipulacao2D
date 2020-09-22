using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCG
{
    class FiltroM
    {
		public static Bitmap dda(Bitmap b, int x1, int x2, int y1, int y2)
		{
			int length = Math.Max(Math.Abs(x2 - x1), Math.Abs(y2 - y1));

            try
            {
				if (length != 0)
				{
					float xinc = (float)(x2 - x1) / length;
					float yinc = (float)(y2 - y1) / length;

					for (float x = x1, y = y1; x < x2; x += xinc, y += yinc)
						b.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.Black);
				}
			}
			catch(Exception e)
			{ }

			return b;
		}

		public static void Trigonometria(int xi, int yi, int xf, int yf, Bitmap b)
		{
			double r = 0;
			int x, y;

			try
			{
				r = Math.Sqrt(Math.Pow(xf - xi, 2) + Math.Pow(yf - yi, 2));
				for (double i = 0; i < (r / Math.Sqrt(2)); )
				{
					x = (int)(r * Math.Cos(i));
					y = (int)(r * Math.Sin(i));

					b.SetPixel(xi + x, yi + y, Color.Black);
					b.SetPixel(xi + y, yi + x, Color.Black);

					b.SetPixel(xi + y, yi - x, Color.Black);
					b.SetPixel(xi + x, yi - y, Color.Black);

					b.SetPixel(xi - x, yi - y, Color.Black);
					b.SetPixel(xi - y, yi - x, Color.Black);

					b.SetPixel(xi - y, yi + x, Color.Black);
					b.SetPixel(xi - x, yi + y, Color.Black);
					if (r < 50)
						i++;
					else if (r >= 50 && r < 100)
						i += 0.5;
					else
						i += 0.1;
				}
			}
			catch { }
		}

		public static void pontomedio(int xi, int yi, int xf, int yf, Bitmap b)
		{
			double r = 0, d;
			int x, y;

			try
			{
				r = Math.Sqrt(Math.Pow(xf - xi, 2) + Math.Pow(yf - yi, 2));
				x = 0;
				y = (int)r;
				d = 1 - r;
				while (y > x)
				{
					if (d < 0)
						d += 2 * x + 3;
					else
					{
						d += 2 * (x - y) + 5;
						y--;
					}
					x++;
					b.SetPixel(xi + x, yi + y, Color.Black);
					b.SetPixel(xi + y, yi + x, Color.Black);

					b.SetPixel(xi + y, yi - x, Color.Black);
					b.SetPixel(xi + x, yi - y, Color.Black);

					b.SetPixel(xi - x, yi - y, Color.Black);
					b.SetPixel(xi - y, yi - x, Color.Black);

					b.SetPixel(xi - y, yi + x, Color.Black);
					b.SetPixel(xi - x, yi + y, Color.Black);
				}
			}
			catch { }
		}
	}
}
