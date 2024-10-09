using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class ExercicioSwitch
    {
        public static void Executar()
        {

            Console.WriteLine("Digite o nome de um mês (por exemplo: Janeiro, Fevereiro, etc.):");
            string mes = Console.ReadLine().ToLower();


            switch (mes)
            {
                case "janeiro":
                case "março":
                case "maio":
                case "julho":
                case "agosto":
                case "outubro":
                case "dezembro":
                    Console.WriteLine("Este mês tem 31 dias.");
                    break;

                case "fevereiro":
                    Console.WriteLine("Este mês tem 28 ou 29 dias.");
                    break;

                case "abril":
                case "junho":
                case "setembro":
                case "novembro":
                    Console.WriteLine("Este mês tem 30 dias.");
                    break;

                default:
                    Console.WriteLine("Mês inválido.");
                    break;
            }
        }
    }
}