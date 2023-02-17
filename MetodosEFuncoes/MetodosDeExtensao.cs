using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro //Criar funções que vão ser adicionadas dentro do INTEIRO (tipo)
    {
        public static int Soma(this int num, int outroNumero) //this representa exatamente o numero que você vai estar trabalhando na função
        {
            return num + outroNumero;
        }
        public static int Subtracao(this int num, int outroNumero) //O que representa que é um função de extensão é o uso do THIS + tipo
        {
            return num - outroNumero;
        }

    }
    internal class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;
            Console.WriteLine(numero.Soma(3)); //A função SOMA está presente num numero inteiro.
            Console.WriteLine(numero.Subtracao(10)); //A função SUBTRACAO está presente num numero inteiro.
            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.Subtracao(4));
        }
    }
}
