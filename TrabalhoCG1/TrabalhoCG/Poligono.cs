using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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

        public void rotacao(int grau)
        {
            double[,] aux = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                aux [i,0] = ma[i,0] * Math.Cos(grau) + ma[i, 1] * Math.Sin(grau);
                aux[i, 1] = ma[i, 0] * -Math.Sin(grau) + ma[i, 1] * Math.Cos(grau);
                aux[i, 2] = ma[i, 2];
            }
            ma = aux;
        }

        public void translacao(int x, int y)
        {
            double[,] aux = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                aux[i, 0] = ma[i, 0];
                aux[i, 1] = ma[i, 1];
                aux[i, 2] = ma[i, 0] * x + ma[i, 1] * y + ma[i,2];
            }
            ma = aux;
        }

        public void cisalhamento(int x, int y)
        {

        }

        public void escala(int x, int y)
        {

        }

        public void espelhamentoV()
        {

        }

        public void espelhamentoH()
        {

        }

        public void setNewAtuais()
        {
            atuais = null;
            atuais = new List<Ponto>();
            foreach (Ponto p in originais)
            {
                atuais.Add(new Ponto(Convert.ToInt32(ma[0,0]*p.getX()+ma[0,1]*p.getY()+ma[0,2]), 
                    Convert.ToInt32(ma[1, 0] * p.getX() + ma[1, 1] * p.getY() + ma[1, 2])));
            }
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
