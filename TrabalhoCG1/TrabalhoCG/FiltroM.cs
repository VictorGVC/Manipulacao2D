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

		public static void scanLine(Poligono p, Color cor, Bitmap b)
		{
			List<Ponto> lp = p.getOriginais();
			int y = 0, ymin = lp[0].getY(), ymax = lp[0].getY(), xmin = 0, incx = 0;
			Ponto p1, p2;

			for (int i = 1 ; i < lp.Count ; i++)
			{
				if (ymin > lp[i].getY())
					ymin = lp[i].getY();
				if(ymax < lp[i].getY())
					ymax = lp[i].getY();
			}

			List<NoScan>[] et = new List<NoScan>[ymax - ymin];

			for (int i = 1 ; i < lp.Count ; i++)
			{
				p1 = lp[i - 1];
				p2 = lp[i];
				if (p1.getY() != p2.getY())
				{
					if (p1.getY() < p2.getY())
					{
						ymin = p1.getY();
						ymax = p2.getY();
						xmin = p1.getX();
					}
					else if (lp[i - 1].getY() > lp[i].getY())
					{
						ymin = p2.getY();
						ymax = p1.getY();
						xmin = p2.getX();
					}
					incx = Math.Abs(p1.getX() - p2.getX()) / Math.Abs(p1.getY() - p2.getY());
					et[ymin].Add(new NoScan(ymax, xmin, incx));
				}
			}

			for (; et[y] == null && y < et.Length; y++) { }

			List<NoScan> aet = et[y++];

			while (aet.Count != 0)
			{
				for (int i = 0; i < aet.Count; i++)
					if (y == aet[i].Ymax)
						aet.RemoveAt(i);
				aet.Sort((o1, o2) => o1.Xmin.CompareTo(o2.Xmin));
				for (int i = 1; i < aet.Count; i += 2)
					for (int x = aet[i - 1].Xmin; x < aet[i].Xmin; x++)
						b.SetPixel(x, y, cor);
				for (int i = 0; i < aet.Count; i++)
					aet[i].Xmin += aet[i].Incx;
				for (; et[y] == null && y < et.Length; y++) { }
				for (int pos2 = 0; pos2 < et[y].Count && y < et.Length; pos2++)
					aet.Add(et[y][pos2]);
			}
		}
	}
}