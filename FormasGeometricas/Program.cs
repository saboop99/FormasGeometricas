using System;
using System.Collections.Generic;
using System.Globalization;

//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
namespace FormasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de uma nova lista
            List<Forma> list = new List<Forma>();
            //Pedir ao usuário para digitar a quantidade de formas
            Console.WriteLine("Entre com o número de formas: ");
            //conversão do valor digitado para int
            int n = int.Parse(Console.ReadLine());

            //utilização do for, condicional para passar por todos os elementos da lista
            for (int i =1; i <=n; i++)
            {
                //Mostrar na tela o número da Forma (Forma #1) de acordo com a condicional do for (i)
                Console.WriteLine($"Forma #{i}:");
                //Pedir ao usuário digitar qual a forma
                Console.WriteLine("Retângulo ou Circulo (R/C)?");
                //Conversão do que foi digitado para char
                char ch = char.Parse(Console.ReadLine());
                //pedir ao usuário para digitar qual a cor
                Console.Write("Cor: (Preto/Azul/Vermelho): ");
                //instanciar variavel cor e utilização do Enum para identificar qual a cor que se tem depositado na classe Color
                Color cor = Enum.Parse<Color>(Console.ReadLine());

                //Condicional caso o usuário digite 'R' (Rêtangulo)
                if(ch == 'R')
                {
                    //printar na tela "Largura" de forma a pedir para que o usuário digite a largura da forma
                    Console.Write("Largura: ");
                    //conversão do valor digitado para double
                    double Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //printar na tela "Altura" de forma a pedir para que o usuário digite a altura da forma
                    Console.Write("Altura: ");
                    //conversão do valor digitado para double
                    double Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //adicionar nova lista para os valores de Retangulo
                    list.Add(new Retangulo(Largura, Altura, cor));
                }
                //condicional usad caso nenhuma outra condicional colocada se concretize
                else
                {
                    //printar na tela "Raio" de forma a pedir para que o usuário digite o raio da forma
                    Console.WriteLine("Raio: ");
                    //conversão do valor digitado para double
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //adicionar nova lista para os valores de Circulo
                    list.Add(new Circulo(raio, cor));
                }

                //Pular uma linha
                Console.WriteLine();
                //Mostrar na tela para o usuário saber o que é a área das formas aparecendo na tela
                Console.WriteLine("A área de cada forma: ");
                //utilização do foreach para passar por cada elemento da lista
                foreach(Forma forma in list)
                {
                    //mostrar o resultado do cálculo da área de cada forma
                    Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
                }

            }
        }
    }
}
