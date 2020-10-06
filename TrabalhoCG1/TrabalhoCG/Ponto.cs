using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCG
{
    public class Ponto
    {
        private int x, y;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        
        public void setX(int n)
        {
            this.x = n;
        }
        public void setY(int n)
        {
            this.y = n;
        }
    }
}
