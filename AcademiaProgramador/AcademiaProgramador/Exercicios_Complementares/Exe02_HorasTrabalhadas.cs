using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProgramador.Exercicios_Complementares
{
    class Exe02_HorasTrabalhadas
    {
        /*A jornada de trabalho semanal de um funcionário é de 40 horas. 
         * O funcionário que trabalhar mais de 40 horas receberá hora extra, 
         * cujo cálculo é o valor da hora regular com um acréscimo de 50%. 
         * Escreva um algoritmo que leia o número de horas trabalhadas em um mês, 
         * o salário por hora e escreva o salário total do funcionário, 
         * que deverá ser acrescido das horas extras, caso tenham sido trabalhadas
         * (considere que o mês possua 4 semanas exatas).*/

        static void Main2(string[] args)
        {



            Console.WriteLine("Informe o total de horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da hora: ");
            double valorHora = double.Parse(Console.ReadLine());


            if (horasTrabalhadas <= 40)
            {
                double salarioFinal = horasTrabalhadas * valorHora;

                Console.WriteLine("O seu salario final e: " + salarioFinal);
            }
            else
                if (horasTrabalhadas > 40)
                {
                    double salarioTotalExtra = (horasTrabalhadas + ((horasTrabalhadas * valorHora) + 0.5));
                    Console.WriteLine("O seu salario final e: " + salarioTotalExtra);
                }


            Console.ReadKey();

        }
    }
}
