using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeRepeticao
{
    class EstruturaFor
    {
        public static void Executar ()
        {
            int resultado = 0;

            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine("Digite um numero:");
                int.TryParse(Console.ReadLine(), out int numero);

                resultado += numero;

                //resultado = numero + numero

            }

            Console.WriteLine("A soma é de:" + resultado);


        }
    }
}
