using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    class NovoCliente
    {
        public string Nome { get; set; }
        /*GET serve para pegar um valor de um campo
         * e o SET serve para alterar um valor um campo */
    }
    class GetSet
    {
        public static void Executar ()
        {
            NovoCliente cliente1 = new NovoCliente();
            cliente1.Nome = "Tigrinho";
            Console.WriteLine(cliente1.Nome);
        }
    }
}
