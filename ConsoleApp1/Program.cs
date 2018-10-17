using System;
using ConsoleApp1.Heranca;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();
            Figura r = new Retangulo(10,20,"Retangulo");
            lista.Add(r);

            Figura t = new Triangulo(3,5,7,"Triangulo");
            lista.Add(t);

            foreach (Figura figura in lista)
            {
                Console.WriteLine("Figura : " + figura.TipoFigura + ", Area : " + figura.Area() + ", Perimetro: " + figura.Perimetro());
            }
            
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
