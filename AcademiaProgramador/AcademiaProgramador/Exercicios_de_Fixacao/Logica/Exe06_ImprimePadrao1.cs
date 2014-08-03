using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProgramador
{
    class Exe06_ImprimePadrao1
    {
        public static void Main6(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i +": **");
                }
                else
                {
                    Console.WriteLine(i +": *");
                }

            }
            Console.ReadKey();
        }

    }
}
