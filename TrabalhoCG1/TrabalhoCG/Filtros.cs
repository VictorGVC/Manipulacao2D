using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCG
{
	class Filtros
	{

		public static void luminancia(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
		{
			int width = imageBitmapSrc.Width;
			int height = imageBitmapSrc.Height;
			int pixelSize = 3;
			Int32 gs;

			BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			int padding = bitmapDataSrc.Stride - (width * pixelSize);

			unsafe
			{
				byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
				byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

				int r, g, b;
				for (int y = 0; y < height; y++)
				{
					for (int x = 0; x < width; x++)
					{
						b = *(src++);
						g = *(src++);
						r = *(src++);
						gs = (Int32)(r * 0.2990 + g * 0.5870 + b * 0.1140);
						*(dst++) = (byte)gs;
						*(dst++) = (byte)gs;
						*(dst++) = (byte)gs;
					}
					src += padding;
					dst += padding;
				}
			}
			imageBitmapSrc.UnlockBits(bitmapDataSrc);
			imageBitmapDest.UnlockBits(bitmapDataDst);
		}

		public static void convertH(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
		{
			int width = imageBitmapSrc.Width;
			int height = imageBitmapSrc.Height;
			int pixelSize = 3;
			double gs;

			BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			int padding = bitmapDataSrc.Stride - (width * pixelSize);

			unsafe
			{
				byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
				byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

				int r, g, b;
				for (int y = 0; y < height; y++)
				{
					for (int x = 0; x < width; x++)
					{
						b = *(src++);
						g = *(src++);
						r = *(src++);
						gs = calculaH(r,g,b);
						*(dst++) = (byte)gs;
						*(dst++) = (byte)gs;
						*(dst++) = (byte)gs;
					}
					src += padding;
					dst += padding;
				}
			}
			imageBitmapSrc.UnlockBits(bitmapDataSrc);
			imageBitmapDest.UnlockBits(bitmapDataDst);
		}

		public static double calculaH(int r, int g, int b)
		{
			double h;



			if (b <= g)
			{
				h = Convert.ToDouble(Math.Round(Math.Acos((0.5 * ((r-g)+(r-b))) / (Math.Sqrt(Math.Pow((r - g),2) + (r - b) * (g - b))))));
			}
			else
			{
				h = Convert.ToDouble(Math.Round(2 * Math.PI - Math.Acos((0.5 * ((r - g) + (r - b))) / (Math.Sqrt(Math.Pow((r - g), 2) + (r - b) * (g - b))))));
			}

			return h;
		}

		public static void convertS(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
		{
			int width = imageBitmapSrc.Width;
			int height = imageBitmapSrc.Height;
			int pixelSize = 3;
			double gs;

			BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			int padding = bitmapDataSrc.Stride - (width * pixelSize);

			unsafe
			{
				byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
				byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

				int r, g, b;
				for (int y = 0; y < height; y++)
				{
					for (int x = 0; x < width; x++)
					{
						b = *(src++);
						g = *(src++);
						r = *(src++);
						gs = calculaS(r, g, b);
						*(dst++) = (byte)gs;
						*(dst++) = (byte)gs;
						*(dst++) = (byte)gs;
					}
					src += padding;
					dst += padding;
				}
			}
			imageBitmapSrc.UnlockBits(bitmapDataSrc);
			imageBitmapDest.UnlockBits(bitmapDataDst);
		}

		public static double calculaS(int r, int g, int b)
		{
			int min = Math.Min(r, Math.Min(g, b));
			double s = Convert.ToDouble(1 - 3 * min);

			return s;
		}

		public static void convertI(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
		{
			int width = imageBitmapSrc.Width;
			int height = imageBitmapSrc.Height;
			int pixelSize = 3;
			double gs;

			BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			int padding = bitmapDataSrc.Stride - (width * pixelSize);

			unsafe
			{
				byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
				byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

				int r, g, b;
				for (int y = 0; y < height; y++)
				{
					for (int x = 0; x < width; x++)
					{
						b = *(src++);
						g = *(src++);
						r = *(src++);
						gs = calculaI(r, g, b);
						*(dst++) = (byte)gs;
						*(dst++) = (byte)gs;
						*(dst++) = (byte)gs;
					}
					src += padding;
					dst += padding;
				}
			}
			imageBitmapSrc.UnlockBits(bitmapDataSrc);
			imageBitmapDest.UnlockBits(bitmapDataDst);
		}

		public static double calculaI(int r, int g, int b)
		{
			double i = Convert.ToDouble((r + g + b) / 3);

			return i;
		}

		public static void rgbToCmy(int r, int g, int b)
		{
			double c, m, y, k, rf, gf, bf;

			rf = r / 255F;
			gf = g / 255F;
			bf = b / 255F;

			k = verificaCmyk(1 - Math.Max(Math.Max(rf, gf), bf));
			c = verificaCmyk((1 - rf - k) / (1 - k));
			m = verificaCmyk((1 - gf - k) / (1 - k));
			y = verificaCmyk((1 - bf - k) / (1 - k));
		}

		private static double verificaCmyk(double valor)
		{
			if (valor < 0 || double.IsNaN(valor))
			{
				valor = 0;
			}

			return valor;
		}
	}
}
