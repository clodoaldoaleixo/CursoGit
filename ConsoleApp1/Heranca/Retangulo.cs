using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Heranca
{
    public class Retangulo : Figura
    {
        public int Largura { get; set; }
        public int Altura { get; set; }

        public Retangulo(int largura, int altura, string tipo) : base(tipo)
        {
            this.Largura = largura;
            this.Altura = altura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }

        public override double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
    }
}
