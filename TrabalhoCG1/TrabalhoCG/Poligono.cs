using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCG
{
    public class Poligono
    {
        private int id;
        private List<Ponto> atuais;
        private List<Ponto> originais;
        private double[,] ma;

        public Poligono(int id)
        {
            this.id = id;
            ma = new double[,]{ { 1, 0, 0}, { 0, 1, 0}, { 0, 0, 1} };
            atuais = new List<Ponto>();
            originais = new List<Ponto>();
        }

        public double[,] getMa()
        {
            return ma;
        }

        public void setMa(double [,] ma)
        {
            this.ma = ma;
        }

        public int getId()
        {
            return id;
        }

        public void addOriginais(Ponto v)
        {
            originais.Add(v);
        }

        public void addAtuais(Ponto v)
        {
            atuais.Add(v);
        }

        public List<Ponto> getAtuais()
        {
            return atuais;
        }

        public void setAtuais(List<Ponto> v)
        {
            this.atuais = v;
        }

        public List<Ponto> getOriginais()
        {
            return originais;
        }

        public void setOriginais(List<Ponto> v)
        {
            this.originais = v;
        }
    }
}
