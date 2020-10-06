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
            double[,] aux2 = new double[, ] { { Math.Cos(grau*Math.PI/180), -Math.Sin(grau * Math.PI / 180), 0 },
                { Math.Sin(grau * Math.PI / 180), Math.Cos(grau * Math.PI / 180), 0 }, { 0, 0, 1 } };
            for (int i = 0; i < 3; i++)
            { 
                aux[i, 0] = aux2[i, 0] * ma[0, 0] + aux2[i, 1] * ma[1, 0] + aux2[i, 2] * ma[2, 0];
                aux[i, 1] = aux2[i, 0] * ma[0, 1] + aux2[i, 1] * ma[1, 1] + aux2[i, 2] * ma[2, 1];
                aux[i, 2] = aux2[i, 0] * ma[0, 2] + aux2[i, 1] * ma[1, 2] + aux2[i, 2] * ma[2, 2];
            }
            ma = aux;
        }

        public void translacao(int x, int y)
        {
            double[,] aux = new double[3, 3];
            double[,] aux2 = new double[,] { { 1, 0, x }, { 0, 1, y }, { 0, 0, 1 } };
            for (int i = 0; i < 3; i++)
            {
                aux[i, 0] = aux2[i, 0] * ma[0, 0] + aux2[i, 1] * ma[1, 0] + aux2[i, 2] * ma[2, 0];
                aux[i, 1] = aux2[i, 0] * ma[0, 1] + aux2[i, 1] * ma[1, 1] + aux2[i, 2] * ma[2, 1];
                aux[i, 2] = aux2[i, 0] * ma[0, 2] + aux2[i, 1] * ma[1, 2] + aux2[i, 2] * ma[2, 2];
            }
            ma = aux;
        }

        public void cisalhamento(double x,double y)
        {
            double[,] aux = new double[3, 3];
            double[,] auxx = new double[,] { { 1, x, 0 }, { y, 1, 0 }, { 0, 0, 1 } };
            for (int i = 0; i < 3; i++)
            {
                aux[i, 0] = auxx[i, 0] * ma[0, 0] + auxx[i, 1] * ma[1, 0] + auxx[i, 2] * ma[2, 0];
                aux[i, 1] = auxx[i, 0] * ma[0, 1] + auxx[i, 1] * ma[1, 1] + auxx[i, 2] * ma[2, 1];
                aux[i, 2] = auxx[i, 0] * ma[0, 2] + auxx[i, 1] * ma[1, 2] + auxx[i, 2] * ma[2, 2];
            }
            ma = aux;
        }

        public void escala(double x, double y)
        {
            double[,] aux = new double[3, 3];
            double[,] aux2 = new double[,] { { x, 0, 0 }, { 0, y, 0 }, { 0, 0, 1 } };
            for (int i = 0; i < 3; i++)
            {
                aux[i, 0] = aux2[i, 0] * ma[0, 0] + aux2[i, 1] * ma[1, 0] + aux2[i, 2] * ma[2, 0];
                aux[i, 1] = aux2[i, 0] * ma[0, 1] + aux2[i, 1] * ma[1, 1] + aux2[i, 2] * ma[2, 1];
                aux[i, 2] = aux2[i, 0] * ma[0, 2] + aux2[i, 1] * ma[1, 2] + aux2[i, 2] * ma[2, 2];
            }
            ma = aux;
        }

        public void espelhamentoV()
        {
            double[,] aux = new double[3, 3];
            double[,] aux2 = new double[,] { { 1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } };
            for (int i = 0; i < 3; i++)
            {
                aux[i, 0] = aux2[i, 0] * ma[0, 0] + aux2[i, 1] * ma[1, 0] + aux2[i, 2] * ma[2, 0];
                aux[i, 1] = aux2[i, 0] * ma[0, 1] + aux2[i, 1] * ma[1, 1] + aux2[i, 2] * ma[2, 1];
                aux[i, 2] = aux2[i, 0] * ma[0, 2] + aux2[i, 1] * ma[1, 2] + aux2[i, 2] * ma[2, 2];
            }
            ma = aux;
        }

        public void espelhamentoH()
        {
            double[,] aux = new double[3, 3];
            double[,] aux2 = new double[,] { { -1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            for (int i = 0; i < 3; i++)
            {
                aux[i, 0] = aux2[i, 0] * ma[0, 0] + aux2[i, 1] * ma[1, 0] + aux2[i, 2] * ma[2, 0];
                aux[i, 1] = aux2[i, 0] * ma[0, 1] + aux2[i, 1] * ma[1, 1] + aux2[i, 2] * ma[2, 1];
                aux[i, 2] = aux2[i, 0] * ma[0, 2] + aux2[i, 1] * ma[1, 2] + aux2[i, 2] * ma[2, 2];
            }
            ma = aux;
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
