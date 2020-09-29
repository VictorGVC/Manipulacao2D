using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCG
{
    class Poligono
    {
        List<Vertice> vertices;

        public Poligono()
        {
            vertices = new List<Vertice>();
        }

        public List<Vertice> getVertices()
        {
            return vertices;
        }

        public void setVertices(List<Vertice> v)
        {
            this.vertices = v;
        }
    }
}
