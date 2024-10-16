using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeRepeticao
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            //percorrendo letras
            var palavra = "Cortinas";
            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);
            }
            //percorrendo array
            var alunos = new string[] { "Santos", "Palmeiras","Corinthians"};
            foreach(string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

        }
    }
}
