using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProgramador.Exercicios_Complementares
{
    class Exe03_ContaBancaria
    {
        /*Faça um algoritmo para ler: número da conta do cliente, 
         * saldo, débito e crédito. Após, calcular e escrever o 
         * saldo atual (saldo atual = saldo - débito + crédito). 
         * Também testar se saldo atual for maior ou igual a zero 
         * escrever a mensagem 'Saldo Positivo', senão escrever a mensagem 'Saldo Negativo'.*/ 

        public static void Main3(string[] args)
        {
            string numeroDaConta;

            double saldo, debito, credito, saldoAtual;

            Console.WriteLine("Informe o seu saldo:" );
            saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o seu debito:");
            debito = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o seu credito:");
            credito = double.Parse(Console.ReadLine());

            saldoAtual = saldo - debito + credito;

            Console.ReadKey();

        }
    }
}
