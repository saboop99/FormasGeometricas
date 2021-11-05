using System;
using System.Collections.Generic;
using System.Text;

//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
namespace FormasGeometricas
{
    //criação da classe Circulo que herda da classe Forma
    class Circulo:Forma
    {
        //Encapsulamento do Raio
        public double Raio { get; set; }
        
        //método construtor 
        public Circulo (double raio, Color cor) : base(cor)
         {
            Raio = raio;
         }
        //Override do do cálculo da área com a operação matematica da area do circulo
        public override double Area()
        {
            return Math.PI*Raio*Raio;
        }
    }

    
}
