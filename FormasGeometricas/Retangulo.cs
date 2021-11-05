using System;
using System.Collections.Generic;
using System.Text;

//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
namespace FormasGeometricas
{
    class Retangulo : Forma
    {
        //Encapsulamento da Largura
        public double Largura { get; set; }
        //Encapsulamento da Altura
        public double Altura { get; set; }
        
        //método construtor
        public Retangulo(double largura, double altura, Color cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }
        //Override do do cálculo da área com a operação matematica da area do retangulo
        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
