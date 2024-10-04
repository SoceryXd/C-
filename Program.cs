using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar},
                {"Notação Ponto - Fundamentos",NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos",LendoDados.Executar},
                {"Operadores aritméticos - Fundamentos",OperadoresAritmeticos.Executar},
                {"Exercicios - Fundamentos",Exercicios.Executar},
                {"Estrutura If -  Estrutura de Controle",EstruturaIf.Executar}
            });

            central.SelecionarEExecutar();
        }
    }
}