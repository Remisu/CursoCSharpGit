using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesStack
    {
        //Conceito de Stack é o primeiro a entrar, vai ser o ultimo a sair.
        public static void Executar()
        {
            var pilha = new Stack();
            //add items
            pilha.Push(3);
            pilha.Push('a');
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                Console.WriteLine(item + " ");
            }
            //pop remove o primeiro elemento da lista
            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.WriteLine(item + " ");
            }

            //outro conceito é o peek, que vai pegar o valor, mas nao vai remover
            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);
        }
    }
}
