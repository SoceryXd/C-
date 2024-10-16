using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Cliente
    {
        public string Nome;
        public string Cpf;
        public string Sexo;
        public string Endereco;
        public int Idade;

        //contrutor que recebe parâmetro
        public Cliente(string nome, string cpf, string sexo,string endereco, int idade)
        {
            Nome = nome;
            Cpf = cpf;
            Sexo = sexo;
            Endereco = endereco;
            Idade = idade;
        }
        public Cliente()
        {

        }
    }

    class Construtores
    {

        public static void Executar ()
        {
            //construtor padrão
            var cliente1 = new Cliente();
            cliente1.Nome = "Enzo Henrique Pandolfo Callemi";
            cliente1.Cpf = "434.674.598-97";
            cliente1.Sexo = "M";
            cliente1.Endereco = "Rua bartira 367";
            cliente1.Idade = 21;

            Console.WriteLine($"{cliente1.Nome} e {cliente1.Cpf} e {cliente1.Sexo} seu {cliente1.Endereco} sua {cliente1.Idade}");

            var cliente2 = new Cliente("José", "123456789", "M", "Parque das América", 70);

            var cliente3 = new Cliente()
            {
                Nome = "Matheus Cantarino Tinti",
                Cpf = "247.764.862.20",
                Sexo = "M",
                Endereco = "Rua Bartira",
                Idade = 21
            };
        }

    }
}
