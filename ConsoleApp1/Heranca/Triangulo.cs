using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Heranca
{
    public class Triangulo : Figura
    {
        public int LadoA { get; set; }
        public int LadoB { get; set; }
        public int LadoC { get; set; }

        public Triangulo(int ladoA, int ladoB, int ladoC, string tipo) : base(tipo)
        {
            this.LadoA = ladoA;
            this.LadoB = ladoB;
            this.LadoC = ladoC;
        }

        public override double Area()
        {
            return 0;
        }

        public override double Perimetro()
        {
            return LadoA + LadoB + LadoC;
        }
    }
}
