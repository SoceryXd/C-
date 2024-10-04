using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual seu nome?:");
            string nome = Console.ReadLine();

            //quando solicitamos ao usuário um dado do tipo
            //inteiro ou real, precisamos converter usando Parse

            Console.WriteLine("Em que posição o Vasco está?");
            int posicao = int.Parse(Console.ReadLine());

            Console.WriteLine($"Seu nome é {nome} e a posição do Vasco {posicao}");

        }
    }
}
