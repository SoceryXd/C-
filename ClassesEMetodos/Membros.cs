using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {

        public static void Executar()
        {

            /* criando o objeto a 
             * partir da classe Pessoa*/

            Pessoa pessoa1 = new Pessoa();

            /*usando os atributos da classe pessoa */
            pessoa1.Nome = "Eva";
            pessoa1.Idade = 30;
            pessoa1.Sexo = "F";

            /*exibindo os dados */
            Console.WriteLine($"Olá {pessoa1.Nome} você tem {pessoa1.Idade} anos");
        }
    }
}
