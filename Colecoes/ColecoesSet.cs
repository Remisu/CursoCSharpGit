using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesSet
    {
        public static void Executar()
        {
            //vou criar um produto que vai ser um livro
            var livro = new Produto("Game of Thrones", 49.9);

            //Agora vou criar uma lista, como se fosse um carrinho de compras

            //No momento que trabalhar com Hashset e não com list, vai perder algumas coisas
            //1-O set é uma estrutura que não é indexada, toda função que envolve index, não funciona
            //2-O set é uma estrutura que não aceita repetição.

            var carrinho = new HashSet<Produto>(); //dentro do simbolo de maior e menor, por o tipo de dado que vc quer que a lista armazene.
            carrinho.Add(livro); //adicionando o livro do game of thrones no carrinho.
            //A vantagem da lista em comparação ao array é que você pode adicionar items sem uma limitação.

            //criar outro conjunto de elementos, que seria um combo
            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8a Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            //AddRange adiciona o conteudo de uma lista dentro de outra
            //carrinho.AddRange(combo); //todos os elementos que fazem parte desse combo, vão ser adicionados no carrinho de compra.
            //Essas funções não funcionam mais porque o range é por índice, vai ter que ser substituído pelas funções do Set.

            carrinho.UnionWith(combo); //ou seja, ele vai alterar o carrinho para ser a união com o combo.
            Console.WriteLine(carrinho.Count + " Elemento(s)");
            //carrinho.RemoveAt(3); //Remover o elemento de indice 3.

            foreach (var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item)); //só write pra deixar o index mostrando antes dos produtos.
                Console.WriteLine(" - " + item.Nome + " " + item.Preco);
            }

            //explorar outros metodos da lista escrevendo "Carrinho." e vendo as opções de lista que tem..
            Console.WriteLine(carrinho.Count + " Elemento(s)");
            carrinho.Add(livro); //a lista aceita repetições //o Set não aceita
            Console.WriteLine(carrinho.Count + " Elemento(s)");
            //Console.WriteLine(carrinho.LastIndexOf(livro)); //mostra o ultimo index do livro
        }
    }
}
