using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCG
{
    class RGB
    {
        private double r, g, b;

        public RGB(double r, double g, double b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public RGB()
        {
        }

        public void setR(double r)
        {
            this.r = r;
        }

        public void setG(double g)
        {
            this.g = g;
        }

        public void setB(double b)
        {
            this.b = b;
        }

        public double getR()
        {
            return r;
        }

        public double getG()
        {
            return g;
        }

        public double getB()
        {
            return b;
        }
    }
}
