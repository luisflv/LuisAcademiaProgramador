using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProgramador.Exercicios_de_Fixacao.Complementares
{
    class Exe02_ImprimeVariosTriangulos
    {
        public static void Main2(string[] args)
        {
            ImprimeTriangulo();
            ImprimeTriangulo();
            ImprimeTriangulo();

            Console.ReadKey();
        }

        public static void ImprimeTriangulo()
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
        }
    }
}
