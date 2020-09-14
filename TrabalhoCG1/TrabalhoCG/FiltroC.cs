using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCG
{
    class FiltroC
    {
        public static void EqGeralCircunferencia(int xi, int yi, int xf, int yf, Bitmap b)
        {
            double r = 0;
            int y;
            try
            {
                /*Euclidiana*/
                r = Math.Sqrt(Math.Pow(xf - xi, 2) + Math.Pow(yf - yi, 2));
                /*---------*/
                for (int i = 0; i < (r/Math.Sqrt(2)); i++)
                {
                    y = (int)Math.Round(Math.Sqrt(Math.Pow(r, 2) - Math.Pow(xf, 2)));//erro = valor negativo
                    /*Simetria de Ordem 8*/
                    b.SetPixel(xi + xf, yi + y, Color.Gray);
                    b.SetPixel(xi + y, yi + xf, Color.Gray);

                    b.SetPixel(xi + y, yi - xf, Color.Gray);
                    b.SetPixel(xi + xf, yi - y, Color.Gray);

                    b.SetPixel(xi - xf, yi - y, Color.Gray);
                    b.SetPixel(xi - y, yi - xf, Color.Gray);

                    b.SetPixel(xi - y, yi + xf, Color.Gray);
                    b.SetPixel(xi - xf, yi + y, Color.Gray);
                }
            }
            catch { }
        }
    }
}
