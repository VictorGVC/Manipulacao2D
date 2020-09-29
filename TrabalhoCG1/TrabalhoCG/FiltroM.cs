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
		public static Bitmap retaDda(Bitmap b, int x1, int x2, int y1, int y2)
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

		public static void circTrigonometria(int xi, int yi, int xf, int yf, Bitmap b)
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
						i += 0.5;
					else
						i += 0.1;
				}
			}
			catch (Exception e){ }
		}

		public static void circPontomedio(int xi, int yi, int xf, int yf, Bitmap b)
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
			catch (Exception e){ }
		}

		public static void simetriaQua(int x, int y, int x1, int y1, Bitmap bit)
		{
			bit.SetPixel(x1 + x, y1 + y, Color.Black);
			bit.SetPixel(x1 - x, y1 + y, Color.Black);
			bit.SetPixel(x1 - x, y1 - y, Color.Black);
			bit.SetPixel(x1 + x, y1 - y, Color.Black);
		}

		public static void elipse(int a, int b, int x1, int y1, Bitmap bit)
		{
			try
			{
				int x = 0, y = b;
				double d1, d2;

				d1 = Math.Pow(b, 2) - Math.Pow(a, 2) * b + Math.Pow(a, 2) / 4;
				simetriaQua(x, y, x1, y1, bit);
				while (Math.Pow(a, 2) * (y - 0.5) > Math.Pow(b, 2) * (x + 1))
				{
					if (d1 < 0)
						d1 = d1 + Math.Pow(b, 2) * (2 * x + 3);
					else
					{
						d1 = d1 + Math.Pow(b, 2) * (2 * x + 3) + Math.Pow(a, 2) * (-2 * y + 2);
						y--;
					}
					simetriaQua(++x, y, x1, y1, bit);
				}
				d2 = Math.Pow(b, 2) * (x + 0.5) * (x + 0.5) + Math.Pow(a, 2) * (y - 1) * (y - 1) - Math.Pow(a, 2) * Math.Pow(b, 2);
				while (y > 0)
				{
					if (d2 < 0)
					{
						d2 = d2 + Math.Pow(b, 2) * (2 * x + 2) + Math.Pow(a, 2) * (-2 * y + 3);
						x++;
					}
					else
						d2 = d2 + Math.Pow(a, 2) * (-2 * y + 3);
					simetriaQua(x, --y, x1, y1, bit);
				}
			}
			catch(Exception e) { }
		}
	}
}
