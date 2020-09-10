using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

		public static void convertHSItoRGB(Bitmap imageBitmapSrc, Bitmap imageBitmapSrc2, Bitmap imageBitmapSrc3, Bitmap imageBitmapDest, int vh, int vi)
        {
			int width = imageBitmapSrc.Width;
			int height = imageBitmapSrc.Height;
			int pixelSize = 3;

			BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData bitmapDataSrc2 = imageBitmapSrc2.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData bitmapDataSrc3 = imageBitmapSrc3.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			int padding = bitmapDataSrc.Stride - (width * pixelSize);

			unsafe
			{
				string []rgb;
				string RGB;
				byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
				byte* src2 = (byte*)bitmapDataSrc2.Scan0.ToPointer();
				byte* src3 = (byte*)bitmapDataSrc3.Scan0.ToPointer();
				byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

				double h, s, i;
				double r, g, b;
				for (int y = 0; y < height - 1; y++)
				{
					for (int x = 0; x < width; x++)
					{
						h = *(src+=3);
						s = *(src2+=3);
						i = *(src3+=3);

						RGB = returnRGB(h+vh,s,i+vi);
						rgb = RGB.Split('/');

						r = 255*Double.Parse(rgb[0]);
						g = 255*Double.Parse(rgb[1]);
						b = 255*Double.Parse(rgb[2]);

						*(dst++) = (byte)b;
						*(dst++) = (byte)g;
						*(dst++) = (byte)r;
					}
					src2 += padding;
					src3 += padding;
					src += padding;
					dst += padding;
				}
			}
			imageBitmapSrc.UnlockBits(bitmapDataSrc);
			imageBitmapDest.UnlockBits(bitmapDataDst);
			imageBitmapSrc2.UnlockBits(bitmapDataSrc2);
			imageBitmapSrc3.UnlockBits(bitmapDataSrc3);
		}

		private static string returnRGB(double h, double s, double i)
        {
			h = (h*360.0/255.0) * Math.PI / 180.0;
			s = s / 100.0;
			i = i / 255;
			double x, y, z;
			string aoba = "";
			double H = h;

			

			if (2 * Math.PI / 3 <= h && h < 4 * Math.PI / 3)
				h = h - 2.0 * Math.PI / 3.0;
			else if (h >= 4 * Math.PI / 3)
				h = h - 4.0 * Math.PI / 3.0;

			x = (i * (1.0 - s));
			y = (i * (1.0 + ((s * Math.Cos(h))/(Math.Cos(Math.PI/3.0-h)))));
			z = (3.0 * i - (x + y));

			if (x > 1)
				x = 1;
			if (y > 1)
				y = 1;
			if (z > 1)
				z = 1;

			if (H < 2 * Math.PI / 3)
				aoba = y + "/" + z + "/" + x;
			else if (2 * Math.PI / 3 <= H && H < 4 * Math.PI / 3)
				aoba = x + "/" + y + "/" + z;
			else
				aoba = z + "/" + x + "/" + y;

			return aoba;
        }

		public static void convertHSI(Bitmap imageBitmapSrc, Bitmap imageBitmapDestH, Bitmap imageBitmapDestS, 
			Bitmap imageBitmapDestI, Bitmap imageBitmapDestCMY)
		{
			int width = imageBitmapSrc.Width;
			int height = imageBitmapSrc.Height;
			int pixelSize = 3;
			string sHSI;
			string[] shsi;
			string scmy;
			string[] sCMY;

			BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData bitmapDataDstH = imageBitmapDestH.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData bitmapDataDstS = imageBitmapDestS.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData bitmapDataDstI = imageBitmapDestI.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData bitmapDataDstCMY = imageBitmapDestCMY.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			int padding = bitmapDataSrc.Stride - (width * pixelSize);

			unsafe
			{
				byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
				byte* h = (byte*)bitmapDataDstH.Scan0.ToPointer();
				byte* s = (byte*)bitmapDataDstS.Scan0.ToPointer();
				byte* i = (byte*)bitmapDataDstI.Scan0.ToPointer();
				byte* cmy = (byte*)bitmapDataDstCMY.Scan0.ToPointer();

				double r, g, b;
				for (int y = 0; y < height; y++)
				{
					for (int x = 0; x < width; x++)
					{
						b = *(src++);
						g = *(src++);
						r = *(src++);
						sHSI = calculaHSI(r, g, b);
						shsi = sHSI.Split('/');
						*(h++) = (byte)Double.Parse(shsi[0]);
						*(h++) = (byte)Double.Parse(shsi[0]);
						*(h++) = (byte)Double.Parse(shsi[0]);
						*(s++) = (byte)Double.Parse(shsi[1]);
						*(s++) = (byte)Double.Parse(shsi[1]);
						*(s++) = (byte)Double.Parse(shsi[1]);
						*(i++) = (byte)Double.Parse(shsi[2]);
						*(i++) = (byte)Double.Parse(shsi[2]);
						*(i++) = (byte)Double.Parse(shsi[2]);

						scmy = rgbToCmy(r, g, b);
						sCMY = scmy.Split('/');
						*(cmy++) = (byte)Double.Parse(sCMY[0]);
						*(cmy++) = (byte)Double.Parse(sCMY[1]);
						*(cmy++) = (byte)Double.Parse(sCMY[2]);
					}
					src += padding;
					h += padding;
					s += padding;
					i += padding;
				}
			}
			imageBitmapSrc.UnlockBits(bitmapDataSrc);
			imageBitmapDestH.UnlockBits(bitmapDataDstH);
			imageBitmapDestS.UnlockBits(bitmapDataDstS);
			imageBitmapDestI.UnlockBits(bitmapDataDstI);
			imageBitmapDestCMY.UnlockBits(bitmapDataDstCMY);
		}

		
		public static string calculaHSI(double r,double g, double b)
        {
			string str;
			double h;
			double soma = r + b + g;
			double i = (r + g + b) / 3;
			
			r = r / soma;
			b = b / soma;
			g = g / soma;


			if (b > g)
			{
				h = (2 * Math.PI) - Math.Acos(((0.5 * ((r - g) + (r - b))) / Math.Pow((Math.Pow(r - g, 2) + ((r - b) * (g - b))), 0.5f)));
			}
			else
			{
				h = Math.Acos(((0.5f * ((r - g) + (r - b))) / Math.Pow((Math.Pow(r - g, 2) + ((r - b) * (g - b))), 0.5f)));
			}
			if (Double.IsNaN(h))
				h = 0;
			double s = 1 - (3 * Math.Min(r, Math.Min(g, b)));
			i = (double)soma / 765.0;

			str = (((h * 180.0) / Math.PI)*255.0)/360.0 + "/"+ s * 100.0 + "/"+ i * 255.0;

			return str;
		}

		public static string rgbToCmy(double r, double g, double b)
		{
			double c, m, y, k;
			string cmy = "";

			k = 1 - (Math.Max(Math.Max(r, g), b) / 255);
			c = (1 - (r / 255) - k) / (1 - k) * 255;
			m = (1 - (g / 255) - k) / (1 - k) * 255;
			y = (1 - (b / 255) - k) / (1 - k) * 255;

			cmy = c + "/" + m + "/" + y;

			return cmy;
		}

		public static void convertRGBtoRGBH(Bitmap imageBitmap,int vh)
        {
			int width = imageBitmap.Width;
			int height = imageBitmap.Height;
			int pixelSize = 3;
			string sHSI;
			string[] shsi;
			string RGB;
			string[] rgb;

			BitmapData bitmapData = imageBitmap.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			int padding = bitmapData.Stride - (width * pixelSize);

			unsafe
			{
				byte* p1 = (byte*)bitmapData.Scan0.ToPointer();
				byte* p2 = (byte*)bitmapData.Scan0.ToPointer();

				int r, g, b;
				for (int y = 0; y < height; y++)
				{
					for (int x = 0; x < width; x++)
					{
						b = *(p1++);
						g = *(p1++);
						r = *(p1++);

						sHSI = calculaHSI(r, g, b);
						shsi = sHSI.Split('/');
						RGB = returnRGB(Double.Parse(shsi[0]) + vh, Double.Parse(shsi[1]), Double.Parse(shsi[2]));
						rgb = RGB.Split('/');

						*(p2++) = (byte)(255*Double.Parse(rgb[2]));
						*(p2++) = (byte)(255*Double.Parse(rgb[1]));
						*(p2++) = (byte)(255*Double.Parse(rgb[0]));
					}
					p1 += padding;
					p2 += padding;
				}
			}
			imageBitmap.UnlockBits(bitmapData);
	}

		/*
		public static void brilho(Bitmap imageBitmapSrc, Bitmap imageBitmapDest, int valor)
		{
			int width = imageBitmapSrc.Width;
			int height = imageBitmapSrc.Height;
			int pixelSize = 3;

			BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			int padding = bitmapDataSrc.Stride - (width * pixelSize);

			unsafe
			{
				byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
				byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

				int h, s, i;
				for (int y = 0; y < height; y++)
				{
					for (int x = 0; x < width; x++)
					{
						h = *(src++);
						s = *(src++);
						i = *(src++);
						*(dst++) = (byte)(i + valor);
						*(dst++) = (byte)(i + valor);
						*(dst++) = (byte)(i + valor);
					}
					src += padding;
					dst += padding;
				}
			}
			imageBitmapSrc.UnlockBits(bitmapDataSrc);
			imageBitmapDest.UnlockBits(bitmapDataDst);
		}

		public static void matiz(Bitmap imageBitmapSrc, Bitmap imageBitmapDest, int valor)
		{
			int width = imageBitmapSrc.Width;
			int height = imageBitmapSrc.Height;
			int pixelSize = 3;

			BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			int padding = bitmapDataSrc.Stride - (width * pixelSize);

			unsafe
			{
				byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
				byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

				int h, s, i;
				for (int y = 0; y < height; y++)
				{
					for (int x = 0; x < width; x++)
					{
						h = *(src++);
						if (h != 0)
							h = h;
						s = *(src++);
						i = *(src++);

						*(dst++) = (byte)(h + valor);
						*(dst++) = (byte)(h + valor);
						*(dst++) = (byte)(h + valor);
					}
					src += padding;
					dst += padding;
				}
			}
			imageBitmapSrc.UnlockBits(bitmapDataSrc);
			imageBitmapDest.UnlockBits(bitmapDataDst);
		}*/
	}
}