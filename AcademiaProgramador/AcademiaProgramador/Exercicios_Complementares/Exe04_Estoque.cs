using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProgramador.Exercicios_Complementares
{
    class Exe04_Estoque
    {
        /*Faça um algoritmo para ler: quantidade atual em estoque,
         * quantidade máxima em estoque e quantidade mínima em estoque de um produto. 
         * Calcular e escrever a quantidade média ((quantidade média = quantidade máxima + quantidade mínima) /2). 
         * Se a quantidade em estoque for maior ou igual a quantidade média escrever a mensagem 'Não efetuar compra',
         * senão escrever a mensagem 'Efetuar compra'.*/ 

        public static void Main4(string[] args)
        {
            int qtdAtual, qtdMaxima, qtdMinima;

            double qtdMedia;

            Console.WriteLine("Informe a quantidade atual: ");
            qtdAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade maxima: ");
            qtdMaxima = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade minima: ");
            qtdMinima = int.Parse(Console.ReadLine());

            qtdMedia =  ((qtdMaxima + qtdMinima) /2);

            if (qtdAtual >= qtdMedia)
            {
                Console.WriteLine("Nao podera ser efetuado a compra!");
            }
            else
            {
                Console.WriteLine("Podera ser realizado a compra!");
            }

            Console.ReadKey();

        }
    }
}
