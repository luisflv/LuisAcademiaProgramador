using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProgramador
{
    class Exe07_ImprimePadrao2
    {
        public static void Main7(string[] args)
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
            Console.ReadKey();
        }
    }
}
