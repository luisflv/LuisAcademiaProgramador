using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProgramador.Exercicios_Complementares
{
    class Exe01_JogoXadrez
    {
        /*Ler a hora de início e a hora de fim de um jogo de Xadrez 
         * (considere apenas horas inteiras, sem os minutos) e calcule a duração do jogo em horas, 
         * sabendo-se que o tempo máximo de duração do jogo é de 24 horas e que o jogo pode iniciar 
         * em um dia e terminar no dia seguinte*/


        static void Main1(string[] args)
        {

            int horaInicial, horaFinal, totalHoras;

            Console.WriteLine("Informe a hora inicial do jogo: ");
            horaInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a hora final do jogo: ");
            horaFinal = int.Parse(Console.ReadLine());

            totalHoras = horaFinal - horaInicial;

            if (totalHoras >= 24)
            {
                Console.WriteLine("Tempo maximo de duracao do jogo");
            }
            else
            {
                Console.WriteLine("A partida durou " +totalHoras +" horas");
            }
            Console.ReadKey();
        }
    }
}
