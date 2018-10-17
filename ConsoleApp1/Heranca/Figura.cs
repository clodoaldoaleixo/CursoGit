using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Heranca
{
    interface IFigura
    {
        double Area();
        double Perimetro();
    }

    public abstract class Figura
    {
        public string TipoFigura { get; set; }

        public Figura(string tipo)
        {
            this.TipoFigura = tipo;
        }

        public abstract double Area();
        public abstract double Perimetro();
    }
}
