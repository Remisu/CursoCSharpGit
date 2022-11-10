using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    //criar um classe chamada produto com dois atributos
    public class Produto //Se segurar Ctrl + Ponto tu consegue gerar o hashcode, ou seja, criptografar.
    {
        public string Nome;
        public double Preco;

        //criar o construtor
        public Produto(string nome, double preco) 
        {
            Nome = nome;
            Preco = preco;
        }

        //Isso aqui foi implementado para ser utilizado no exercício de "Igualdade", para poder comparar o valor do produto e nao a referencia de memoria.
        public override bool Equals(object? obj)
        {
            Produto? outroProduto = obj as Produto;
            bool mesmoNome = Nome == outroProduto?.Nome;
            bool mesmoPreco = Preco == outroProduto?.Preco;
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode() //Com o hashcode, o elemento de Nome e Preco em conjunto tem um identificador criptografado.
        {
            return HashCode.Combine(Nome, Preco);
        }

 
    }
    internal class ColecoesList
    {
        public static void Executar()
        {
            //vou criar um produto que vai ser um livro
            var livro = new Produto("Game of Thrones", 49.9);

            //Agora vou criar uma lista, como se fosse um carrinho de compras
            var carrinho = new List<Produto>(); //dentro do simbolo de maior e menor, por o tipo de dado que vc quer que a lista armazene.
            carrinho.Add(livro); //adicionando o livro do game of thrones no carrinho.
            //A vantagem da lista em comparação ao array é que você pode adicionar items sem uma limitação.

            //criar outro conjunto de elementos, que seria um combo
            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8a Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            //AddRange adiciona o conteudo de uma lista dentro de outra
            carrinho.AddRange(combo); //todos os elementos que fazem parte desse combo, vão ser adicionados no carrinho de compra.
            Console.WriteLine(carrinho.Count + " Elemento(s)");
            carrinho.RemoveAt(3); //Remover o elemento de indice 3.

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item)); //só write pra deixar o index mostrando antes dos produtos.
                Console.WriteLine(" - " + item.Nome + " " + item.Preco);
            }

            //explorar outros metodos da lista escrevendo "Carrinho." e vendo as opções de lista que tem..
            Console.WriteLine(carrinho.Count + " Elemento(s)");
            carrinho.Add(livro); //a lista aceita repetições
            Console.WriteLine(carrinho.Count + " Elemento(s)");
            Console.WriteLine(carrinho.LastIndexOf(livro)); //mostra o ultimo index do livro
        }
    }
}
