using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProgramador.Exercicios_de_Fixacao.Complementares
{
    class Exe03_SerieFibonacci
    {
        public static void Main3(string[] args)
        {
            int a = 0, aux;

            int b = 1;

            int valor = 5;


            for (int i = 0; i < valor; i++)
            {
                aux = a + b;
                a = b;
                b = aux;
                Console.WriteLine(aux);
            }

            Console.ReadKey();
        }
    }
}