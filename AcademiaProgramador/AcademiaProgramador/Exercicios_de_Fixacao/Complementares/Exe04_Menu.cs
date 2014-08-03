using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProgramador.Exercicios_de_Fixacao.Complementares
{
    class Exe04_Menu
    {
        public static void Main4(string[] args)
        {
            int var = 1;

            while (var != 0)
            {
                Console.WriteLine("  - Menu - ");
                Console.WriteLine("1 - Padrão 1");
                Console.WriteLine("2 - Padrão 2");
                Console.WriteLine("3 - Padrão 3");
                Console.WriteLine("4 - Padrão 4");
                Console.WriteLine("5 - Padrão 5");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1 : Padrao1();
                        break;
                    case 2: Padrao2();
                        break;
                    case 3:Padrao3() ;
                        break;
                    case 4: Padrao4();
                        break;
                    case 5: Padrao5();
                        break;
                    default: Console.WriteLine("Escolha uma das opcoes") ;
                        break;
                }

            }
        }

        public static void Padrao1()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + ": **");
                }
                else
                {
                    Console.WriteLine(i + ": *");
                }

            }
        }

        public static void Padrao2()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine("PI");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Padrao3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i + ": Luís Fernando");
            }
        }
        public static void Padrao4()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Padrao5()
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
