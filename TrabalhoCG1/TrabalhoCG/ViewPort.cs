using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoCG
{
    public partial class ViewPort : Form
    {
        public ViewPort()
        {
            InitializeComponent();
			this.Width = TelaPrincipal.w;
			this.Height = TelaPrincipal.h;
			pbviewport.Width = TelaPrincipal.w;
            pbviewport.Height = TelaPrincipal.h;

			pbviewport.Image = new Bitmap(TelaPrincipal.w, TelaPrincipal.h);

			foreach (Poligono item in TelaPrincipal.polVP)
            {
				double dx;
				double dy;
				double x1, y1, x2, y2;
				Bitmap b;

				for (int i = 0; i < item.getAtuais().Count-1; i++)
				{
					x1 = item.getAtuais()[i].getX() / 735.0 * pbviewport.Width;
					y1 = item.getAtuais()[i].getY() / 438.0 * pbviewport.Height;

					x2 = item.getAtuais()[i+1].getX() / 735.0 * pbviewport.Width;
					y2 = item.getAtuais()[i+1].getY() / 438.0 * pbviewport.Height;

					dx = x2 - x1;
					dy = y2 - y1;

					if (x1 != 0 && y1 != 0)
					{
						b = new Bitmap(pbviewport.Image);
						bresenham(dx, dy, (int)x1, (int)y1, (int)x2, (int)y2, b);
					}
				}

				x1 = item.getAtuais()[item.getAtuais().Count-1].getX() / 735.0 * pbviewport.Width;
				y1 = item.getAtuais()[item.getAtuais().Count-1].getY() / 438.0 * pbviewport.Height;

				x2 = item.getAtuais()[0].getX() / 735.0 * pbviewport.Width;
				y2 = item.getAtuais()[0].getY() / 438.0 * pbviewport.Height;

				dx = x2 - x1;
				dy = y2 - y1;

				if (x1 != 0 && y1 != 0)
				{
					b = new Bitmap(pbviewport.Image);
					bresenham(dx, dy, (int)x1, (int)y1, (int)x2, (int)y2, b);
				}

			}
        }

		private void bresenham(double dx, double dy, int x1, int y1, int x2, int y2, Bitmap b)
		{
			if (dx != 0 && dy != 0)
			{
				if (Math.Abs(dy) > Math.Abs(dx))
				{
					if (x1 < x2)
					{
						if (y1 < y2)
							FiltroV.BresenhamHigh(x1, y1, b, dx, dy, 1, 1);
						else
						{
							dy *= -1;
							FiltroV.BresenhamHigh(x1, y1, b, dx, dy, 1, -1);
						}
					}
					else
					{
						dx *= -1;
						if (y1 < y2)
							FiltroV.BresenhamHigh(x1, y1, b, dx, dy, -1, 1);
						else
						{
							dy *= -1;
							FiltroV.BresenhamHigh(x1, y1, b, dx, dy, -1, -1);
						}
					}
				}
				else
				{
					if (x1 < x2)
					{
						if (y1 < y2)
							FiltroV.BresenhamLow(x1, y1, b, dx, dy, 1, 1);
						else
						{
							dy *= -1;
							FiltroV.BresenhamLow(x1, y1, b, dx, dy, 1, -1);
						}
					}
					else
					{
						dx *= -1;
						if (y1 < y2)
							FiltroV.BresenhamLow(x1, y1, b, dx, dy, -1, 1);
						else
						{
							dy *= -1;
							FiltroV.BresenhamLow(x1, y1, b, dx, dy, -1, -1);
						}
					}
				}
				pbviewport.Image = b;
			}
		}
	}
}
