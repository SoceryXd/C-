using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes { 
    public static void Executar () {

            string nome = "Luiz";
            int idade = 21;
            string sexo = "M";
            double altura = 1.80;
            bool temCachorro = true;

            Console.WriteLine($"Olá meu nome é {nome} e eu tenho {idade} anos ,  meu sexo é {sexo} minha altura é {altura} eu tenho cachorro {temCachorro}");
            //o var interpreta a variavel que você
            //criou de acordo com o tipo dela

            var time = "Cortinas";
            var posicao = 17;


            //variavel tipo real
            double raio = 4.5;

            //constant
            const double pi = 3.14;

            double area = pi * raio * raio;

            Console.WriteLine("Area total é " +area);
        }
    }
}
