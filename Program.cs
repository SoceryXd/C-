using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.EstruturasDeRepeticao;
using CursoCSharp.ClassesEMetodos;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar},
                {"Notação Ponto - Fundamentos",NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos",LendoDados.Executar},
                {"Operadores Aritméticos - Fundamentos",OperadoresAritmeticos.Executar},
                {"Estrutura If - Estruturas de Controle",EstruturaIf.Executar },
                {"Operadores de Atribuição - Estruturas de Controle",OperadoresAtribuicao.Executar },
                {"Estrutura Switch - Estruturas de Controle",EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Repetição",EstruturaWhile.Executar },
                {"Estrutura For - Estruturas de Repetição",EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de Repetição",EstruturaForEach.Executar},
                {"Membros - Classes e Métodos",Membros.Executar },
                {"Contrutores - Classes e Métodos",Construtores.Executar},
                {"Metodos com Retornos - Classes e Métodos",MetodosComRetorno.Executar },
                {"Atividade Metodos - Classes e Métodos",AtividadeMetodo.Executar }


            });

            central.SelecionarEExecutar();
        }
    }
}