using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresEAtribuições
    {
        public static void Executar()
        {
            //atribuição
            var num = 3;
            //atribuindo o número 3 por 7 
            num = 7;
            //atribuição aditiva
            num += 10; // num = num + 10
            //atribuição subtrativa
            num -= 3; // num = num - 3

            Console.WriteLine(num);
            //INCREMENTO E DECREMENTO
            var a = 1;
            var b = 1;

            a++;
            b--;
            Console.WriteLine($" {a} {b}");
        }
    }
}
