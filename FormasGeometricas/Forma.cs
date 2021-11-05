using System;
using System.Collections.Generic;
using System.Text;

//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
namespace FormasGeometricas
{
    //criação da classe abstrata Forma (abstrata pois tem um método mas não se tem decidido o que ele faz)
    abstract class Forma
    {
        //declaração e encapsulamento da variável Color (tipo Color)
        public Color Color { get; set; }
        //método construtor
        public Forma (Color color)
        {
            Color = color;
        }

        //cálculo da área
        public abstract double Area();
    }
    

    
}
