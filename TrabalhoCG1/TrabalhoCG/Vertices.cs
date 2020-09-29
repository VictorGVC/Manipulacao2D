using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCG
{
    class Vertice
    {
        private int x1, x2, y1, y2;

        public Vertice(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public int getX1()
        {
            return x1;
        }
        public int getX2()
        {
            return x2;
        }
        public int getY1()
        {
            return y1;
        }
        public int getY2()
        {
            return y2;
        }

        public void setX1(int n)
        {
            this.x1 = n;
        }
        public void setX2(int n)
        {
            this.x2 = n;
        }
        public void sety1(int n)
        {
            this.y1 = n;
        }
        public void setY2(int n)
        {
            this.y2 = n;
        }
    }
}
