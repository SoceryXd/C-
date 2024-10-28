using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    class Produto
    {
        private string nome;
        public string Nome {
            get//retornar o nome do produto em letra maiuscula
            {return nome.ToUpper(); }
            //aqui vai continuar atribuindo um valor para nome
            set {nome = value; } 
        }
        private double preco;
        public double Preco
        {
            get { return preco; }
            set
            {
                if (value < 5.00)
                {
                    preco = 5.00;
                }
                else
                { /*caso contrario, eu atribuo o valor ao preco */
                    preco = value;
                }
            }
        }
        public double Desconto { get; set; }
        public double PrecoFinal { get; set; }
        public int EstoqueMinimo { get; set; }
    }
    class GetSet2
    {
        public static void Executar () 
        {
            //instanciando produto
            Produto p1 = new Produto();
            p1.Nome = "Torcida Queijo";
            p1.Preco = 1.99;
            p1.Desconto = 0.05;
            p1.PrecoFinal = p1.Preco - p1.Preco * p1.Desconto;
            p1.EstoqueMinimo = 10;

            Console.WriteLine($"NOME: {p1.Nome} PREÇO: {p1.Preco.ToString("C")} DESCONTO: {p1.Desconto}");

        }
    }
}
