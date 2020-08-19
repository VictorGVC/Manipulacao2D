using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
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

		public static void rgbToHsi(int r, int g, int b)
		{
			int min = Math.Min(r, Math.Min(g, b));
			double h, s, i;

			r = r / (r + g + b);
			g = g / (r + g + b);
			b = b / (r + g + b);

			if (b <= g)
			{
				h = Convert.ToDouble((Math.Round((1 / Math.Cos((0.5 * (2 * r - g - b)) / (Math.Sqrt(((r - g) * (r - g) + (r - b) * (g - b)))))))));
			}
			else
			{
				h = Convert.ToDouble((Math.Round((2 * 3.14 - 1 / Math.Cos((0.5 * (2 * r - g - b)) / (Math.Sqrt(((r - g) * (r - g) + (r - b) * (g - b)))))))));
			}
			s = Convert.ToDouble(1 - 3 * min);
			i = Convert.ToDouble((r + g + b) / (3 * 255));
		}
	}
}
