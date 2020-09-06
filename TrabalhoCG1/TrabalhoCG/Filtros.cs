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

		public static void convertHSItoRGB(Bitmap imageBitmapSrc, Bitmap imageBitmapSrc2, Bitmap imageBitmapSrc3, Bitmap imageBitmapDest)
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

				double r, g, b;
				for (int y = 0; y < height - 1; y++)
				{
					for (int x = 0; x < width; x++)
					{
						b = *(src+=3);
						g = *(src2+=3);
						r = *(src3+=3);
						
						RGB = returnRGB(b,g,r);
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
			h = h * 360 / 255;
			s = s * 100 / 255;
			double x, y, z;
			string aoba = "";
			h = h * Math.PI / 180;
			double H = h;
			s = s / 100;
			i = i / 255;

			if (2 * Math.PI / 3 <= h && h < 4 * Math.PI / 3)
				h = h - 2 * Math.PI / 3;
			else if (h >= 4 * Math.PI / 3)
				h = h - 4 * Math.PI / 3;

			x = (i * (1 - s));
			y = (i * (1 + ((s * Math.Cos(h))/(Math.Cos(Math.PI/3-h)))));
			z = (3 * i - (x + y));

			if (H < 2 * Math.PI / 3)
				aoba = y + "/" + z + "/" + x;
			else if (2 * Math.PI / 3 <= H && H < 4 * Math.PI / 3)
				aoba = x + "/" + y + "/" + z;
			else if (H >= 4 * Math.PI / 3)
				aoba = z + "/" + x + "/" + y;
			return aoba;
        }

		public static void convertHSI(Bitmap imageBitmapSrc, Bitmap imageBitmapDestH, Bitmap imageBitmapDestS, 
			Bitmap imageBitmapDestI, Bitmap imageBitmapDestCMY, Bitmap imageBitmapDestHSI)
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
			BitmapData bitmapDataDstHSI = imageBitmapDestHSI.LockBits(new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			int padding = bitmapDataSrc.Stride - (width * pixelSize);

			unsafe
			{
				byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
				byte* h = (byte*)bitmapDataDstH.Scan0.ToPointer();
				byte* s = (byte*)bitmapDataDstS.Scan0.ToPointer();
				byte* i = (byte*)bitmapDataDstI.Scan0.ToPointer();
				byte* cmy = (byte*)bitmapDataDstCMY.Scan0.ToPointer();
				byte* hsi = (byte*)bitmapDataDstHSI.Scan0.ToPointer();

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

						*(hsi++) = (byte)Double.Parse(shsi[0]);
						*(hsi++) = (byte)Double.Parse(shsi[1]);
						*(hsi++) = (byte)Double.Parse(shsi[2]);
					}
					src += padding;
					h += padding;
					s += padding;
					i += padding;
					hsi += padding;
				}
			}
			imageBitmapSrc.UnlockBits(bitmapDataSrc);
			imageBitmapDestH.UnlockBits(bitmapDataDstH);
			imageBitmapDestS.UnlockBits(bitmapDataDstS);
			imageBitmapDestI.UnlockBits(bitmapDataDstI);
			imageBitmapDestCMY.UnlockBits(bitmapDataDstCMY);
			imageBitmapDestHSI.UnlockBits(bitmapDataDstHSI);
		}

		
		public static string calculaHSI(double r,double g, double b)
        {
			string str;
			double h;
			double soma = r + b + g;
			double i = Convert.ToDouble((r + g + b) / 3);
			r = r / soma;
			b = b / soma;
			g = g / soma;


			if (b <= g)
			{
				h = Math.Acos((0.5 * ((r - g) + (r - b))) / (Math.Sqrt(Math.Pow((r - g), 2.0) + (r - b) * (g - b))));
			}
			else
			{
				h = 2.0 * Math.PI - Math.Acos((0.5 * ((r - g) + (r - b))) / (Math.Sqrt(Math.Pow((r - g), 2.0) + (r - b) * (g - b))));
			}
			if (Double.IsNaN(h))
				h = 0;

			str = ""+((h * 180.0 / Math.PI) * 255.0) / 360.0;

			double min = Math.Min(r, Math.Min(g, b));
			double s = Convert.ToDouble(1 - (3 * min));

			str += "/"+ s * 255.0 +"/"+ i;

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
		}
	}
}