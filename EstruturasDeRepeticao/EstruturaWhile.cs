using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeRepeticao
{
    class EstruturaWhile { 
    public static void Executar ()
        {
            /*
              int contador = 1;

              while (contador <= 10)
              {
                  Console.WriteLine(contador);
                  contador++;
              }
              */

            int contador = 1;
            Console.WriteLine("Quer contar até quando?");
            int.TryParse(Console.ReadLine(), out int valor);

            while (contador <= valor)
            {
                Console.WriteLine(contador);
                contador++; 
            }

        }
    }
}
