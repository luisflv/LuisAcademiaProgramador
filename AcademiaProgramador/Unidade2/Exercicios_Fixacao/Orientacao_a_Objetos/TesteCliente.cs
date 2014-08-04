using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade2.Exercicios_Fixacao.Orientacao_a_Objetos
{
    class TesteCliente
    {
        public static void Main(string[] args)
        {
            Cliente c1 = new Cliente();

            c1.nome = "Luís";
            c1.codigo = 1;
            c1.Fala();

            Cliente c2 = new Cliente();

            c2.nome = "Fernando";
            c2.codigo = 2;


            Console.WriteLine("Nome: " +c1.nome);
            Console.WriteLine("Codigo: " +c1.codigo);


            Console.WriteLine("Nome: " +c2.nome);
            Console.WriteLine("Codigo: " +c2.codigo);

            Console.ReadKey();
        }
    }
}
