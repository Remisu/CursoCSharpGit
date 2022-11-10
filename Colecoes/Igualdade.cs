using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89); //Utilizando o PRODUTO do exercício da "Lista"
            var p2 = new Produto("Caneta", 1.89); //Utilizando o PRODUTO do exercício da "Lista"

            Console.WriteLine(p1 == p2); //O resultado da comparação é falso, porque apontam para locais diferentes de memória.

            var p3 = p2;
            Console.WriteLine(p3 == p2); //O resultado da comparação vai ser true, pois estão a apontar pro mesmo espaço de memória.

            Console.WriteLine(p1.Equals(p2)); //Ainda vai ser falso, porque a função do Equals é comparar endereço de memória. 
            //Mas vai ser igual depois do override no exercicio da Lista.

            //A diferença do Equals e do Hashcode é que o Hashcode é mais rápido, porque ele primeiro compara o Hashcode da lista, e dps os elementos contidos nela.
            //Ex: Comparar nomes de uma lista, e eu quero procurar Ana, no Equals ele vai percorrer elemente por elemente, no Hashcode ele vai comparar primeiro o Hashcode
            //por exemplo, que tenham nome com tamanhos 3 primeiros, e depois comparar os elementos da lista.
        }
    }
}
