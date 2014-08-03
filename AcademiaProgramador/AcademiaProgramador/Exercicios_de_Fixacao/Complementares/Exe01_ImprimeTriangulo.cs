using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProgramador.Exercicios_de_Fixacao.Complementares
{
    class Exe01_ImprimeTriangulo
    {
        public static void Main1(string[] args)
        {
            string asterisco = "*";
            int cont = 1;

            while (cont <= 5)
            {

                for (int i = 0; i < cont; i++)
                {
                    Console.Write(asterisco);
                }

                Console.WriteLine();
                cont++;
            }


            Console.ReadKey();
        }
    }
}
