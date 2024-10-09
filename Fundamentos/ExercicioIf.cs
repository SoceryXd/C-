using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class ExercicioIf {
        public static void Executar ()
        {
            Console.WriteLine("Digite F para Feminino ou M para Masculino:");
            string letra = Console.ReadLine().ToUpper(); 

           
            if (letra == "F")
            {
                Console.WriteLine("F - Feminino");
            }
            else if (letra == "M")
            {
                Console.WriteLine("M - Masculino");
            }
            else
            {
                Console.WriteLine("Sexo inválido");
            }
        }
    }
}

