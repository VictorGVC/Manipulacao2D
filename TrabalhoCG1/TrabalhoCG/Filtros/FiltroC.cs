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
                for (int x = 0; x < (r / Math.Sqrt(2)); x++)
                {
                    y = (int)Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2)); //erro = valor negativo
                    /*Simetria de Ordem 8*/
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
