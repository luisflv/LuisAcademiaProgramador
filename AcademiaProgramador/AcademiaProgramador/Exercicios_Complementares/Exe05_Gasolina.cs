using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProgramador.Exercicios_Complementares
{
    class Exe05_Gasolina
    {
        /*Um posto está vendendo combustíveis com a seguinte tabela de descontos: 
         
         * Álcool até 20 litros, desconto de 3% por litro:
		   Acima de 20 litros, desconto de 5% por litro. 
        
         * Gasolina até 20 litros, desconto de 4% por litro:
		   Acima de 20 litros, desconto de 6% por litro.
        
         * Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível 
        (codificado da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a 
        ser pago pelo cliente sabendo-se que o preço do litro da gasolina é R$ 3,30 e o preço do litro do álcool é R$ 2,90.*/

        public static void Main(string[] args)
        {
            string opcao;

            double qtdLitros, alcVinte, alcMaiorVinte, gasVinte, gasMaiorVinte;

            Console.WriteLine("Informe o tipo do combustivel: ");
            Console.WriteLine("A - alcool");
            Console.WriteLine("g - gasolina");

            opcao = Console.ReadLine();

            opcao.ToLower();

            if (opcao.Equals("a"))
            {
                Console.WriteLine("Informe a quantidade de litros: ");
                qtdLitros = double.Parse(Console.ReadLine());

                if (qtdLitros <= 20)
                {
                    alcVinte = ((2.90 * 0.03) + 2.90 * qtdLitros);
                    Console.WriteLine("Preco: " + alcVinte);
                }
                else
                {
                    alcMaiorVinte = ((2.90 * 0.05) + 2.90 * qtdLitros);
                    Console.WriteLine("Preco: " + alcMaiorVinte);
                }
            }
            else if (opcao.Equals("g"))
            {
                Console.WriteLine("Informe a quantidade de litros: ");
                qtdLitros = double.Parse(Console.ReadLine());
                if (qtdLitros <= 20)
                {
                    gasVinte = ((3.30 * 0.04) + 3.30 * qtdLitros);
                    Console.WriteLine("Preco" + gasVinte);
                }
                else
                {
                    gasMaiorVinte = ((3.30 * 0.06) + 3.30 * qtdLitros);
                    Console.WriteLine("Preco: " + gasMaiorVinte);
                }

            }
            Console.ReadKey();

        }
    }
}
