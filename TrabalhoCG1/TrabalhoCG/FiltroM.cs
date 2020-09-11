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

			if (length != 0)
			{
				float xinc = (float)(x2 - x1) / length;
				float yinc = (float)(y2 - y1) / length;

				for (float x = x1, y = y1; x < x2; x += xinc, y += yinc)
					b.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.Black);
			}

			return b;
		}
    }
}
