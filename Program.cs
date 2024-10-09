using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.EstruturasDeRepeticao;

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
                {"Estrutura If -  Estrutura de Controle",EstruturaIf.Executar},
                {"Estrutura de Controles -  Fundamentos",OperadoresEAtribuições.Executar },
                {"Exercicio de If Else - Fundamento" ,ExercicioIf.Executar },
                {"Exercicio de If Else Senha - Fundamentos",ExercicioSenha.Executar},
                {"Exercicio de If Else Eleição - Fundamentos",ExercicioEleicao.Executar },
                {"Estruturas do Switch - Fundamentos",EstruturasSwitch.Executar },
                {"Exercicio do Switch - Fundamento",ExercicioSwitch.Executar},
                {"Estrutura while - estrutura de Repetição",EstruturaWhile.Executar},
                {"Estrutura for - estrutura de repetução",EstruturaFor.Executar },
                {"Estrutura for e each - estrutura de repetição",EstruturaForIt.Executar },

            });

            central.SelecionarEExecutar();
        }
    }
}