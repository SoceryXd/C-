using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Exercicios {

        public static void Executar() {


            Console.WriteLine("Digite o numero do funcionario:");
            int numeroFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite suas horas trabalhadas:");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("valor recebido por hora:");
            double valorPorHora = double.Parse(Console.ReadLine());

            double salario = horasTrabalhadas * valorPorHora;

            Console.WriteLine("Numero do funcionario:"+numeroFuncionario);
            Console.WriteLine($"Salário: R$ {salario.ToString("F2")}");













            /*
            Console.WriteLine("Digite um numero:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite mais um numero:");
            double n2 = double.Parse(Console.ReadLine());


            double media = (n1 * 3.5 + n2 * 7.5)/ 11;

            Console.WriteLine($"Sua media é de {media.ToString("F1")}");*/






            /* Console.WriteLine("Digite seu primeiro resultado :");
             double n1 = double.Parse(Console.ReadLine());

             Console.WriteLine("Digite o seu segundo resultado :");
             double n2 = double.Parse(Console.ReadLine());

             Console.WriteLine("Digite o seu terceiro resultado :");
             double n3 = double.Parse(Console.ReadLine());

             double media = (n1 + n2 + n3 )/ 3;

             Console.WriteLine($"Sua media é de {media.ToString("F2")}"); */



        }

    }
}
