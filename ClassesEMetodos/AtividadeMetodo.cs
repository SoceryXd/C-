using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Conversor
    {
     
        public double ConverterRealParaDolar(double valorEmReais, double cotacaoDolar)
        {
            return valorEmReais / cotacaoDolar;
        }


        public double ConverterCelsiusParaFahrenheit(double grausCelsius)
        {
            return (grausCelsius * 9 / 5) + 32;
        }
    }

    class AtividadeMetodo
    {
        public static void Executar()
        {
            var conversor = new Conversor();

           
            double valorEmReais = 55.0;
            double cotacaoDolar = 5.0;  
            double valorEmDolares = conversor.ConverterRealParaDolar(valorEmReais, cotacaoDolar);
            Console.WriteLine($"{valorEmReais.ToString()} reais equivalem a {valorEmDolares.ToString()} dólares.");


          
            double grausCelsius = 25.0;
            double grausFahrenheit = conversor.ConverterCelsiusParaFahrenheit(grausCelsius);
            Console.WriteLine($"{grausCelsius.ToString()} graus Celsius equivalem a {grausFahrenheit.ToString()} graus Fahrenheit.");
        }
    }
}