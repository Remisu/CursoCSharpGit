using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Outros;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;




namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Classes e Metodos
                {"Metodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Metodos Estaticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Outros - Exercício do Will de Contar Letras da Palavra", ContarSequenciaDeLetras.Executar},
                {"Desafio Atributos - Classes e Metodos", DesafioAtributo.Executar},
                {"Params - Classes e Metodos", Params.Executar},
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Metodos", GetSet.Executar},
                {"Props - Classes e Metodos", Props.Executar},
                {"ReadOnly - Classes e Metodos", ReadOnly.Executar},
                {"Enum - Classes e Metodos", ExemploEnum.Executar},
                {"Struct - Classes e Metodos", ExemploStruct.Executar},
                {"Struct Vs Classe - Classes e Metodos", StructVsClasse.Executar},
                {"Valor vs. Referencia - Classes e Metodos", ValorVsReferencia.Executar},
                {"Parametros por referencia - Classes e Metodos", ParametrosPorReferencia.Executar},
                {"Teste Out Num - Classes e Metodos", TesteOutNum.Executar},
                {"Parametro com valor Padrao - Classes e Metodos", ParametroPadrao.Executar},


                //Colecões
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Coleções List Array - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Hash - Criptografar", TestandoHashCriptografar.Executar},
                {"Stack - Colecoes", ColecoesStack.Executar},
                {"Dictionary - Colecoes", ColecoesDictionary.Executar},

                //Orientação a objeto
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                 //Metodos e Funções
                {"Exemplo Lambda - Metodos e Funções", ExemploLambda.Executar},
                {"Lambdas Como Delegate", LambdasDelegate.Executar},
                {"Usando Delegates", UsandoDelegate.Executar},
                {"Delegates com Funções Anonimas", DelegateFuncAnonima.Executar},
                {"Delegates como Parametros", DelegatesComoParametros.Executar},
                {"Metodos de Extensão", MetodosDeExtensao.Executar},

                //Exceções
                {"Primeira Exceção", PrimeiraExcecao.Executar},
                {"Excecoes Personalizadas", ExcecoesPersonalizadas.Executar},
                 //API
                { "Primeiro Arquivo - Usando a API", PrimeiroArquivo.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}