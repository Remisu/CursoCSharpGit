using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesDictionary
    {
        public static void Executar()
        {
            //vamos adicionar um dicionário de filmes, que vai armazenar o ano e o nome do filme
            var filmes = new Dictionary<int, string>(); //O dicionário aceita repetição no valor(Nome do filme), mas nao aceita na chave(Ano do Filme).

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "O Grande Truque");

            //Vai verificar se tem o valor na coluna das chaves, seja, a primeira coluna.
            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004 : " + filmes[2004]); //pegar o valor do filme usando a chave.
                //Se tentar acessar uma chave que não existe pode dar erro, por isso há outra forma de pegar o valor
                Console.WriteLine("2004 : " + filmes.GetValueOrDefault(2004)); //ele vai retornar, ou o valor da chave que colocou, ou o valor default que é uma string vazia.

                Console.WriteLine(filmes.ContainsValue("Pulp Fiction")); //Função para saber se existe o valor nas chaves, retorna true ou false.
                Console.WriteLine("Removeu? " + filmes.Remove(2004)); //função de remover vai retornar true ou false

                //outra forma te tentar obter o valor é com TryGetValue e retorna o valor para uma variavel por referencia.
                filmes.TryGetValue(2006, out string filme2006);
                Console.WriteLine($"Filme  {filme2006}!");
                //se não existe, ele nao vai retornar nada.
                filmes.TryGetValue(2007, out string filme2007);
                Console.WriteLine($"Filme  {filme2007}!");

                //Come percorrer o dicionário (4 formas)

                // 1 - Para cada uma das chaves, ele vai mostrar
                foreach(var chave in filmes.Keys)
                {
                    Console.WriteLine(chave);
                }

                // 2 - Percorrendo somente os valores
                foreach(var valor in filmes.Values) 
                { 
                    Console.WriteLine(valor);
                } 

                // 3 - KeyValuePair para apanhar os pares.
                foreach(KeyValuePair<int, string> filme in filmes)
                {
                    Console.WriteLine($"{filme.Value} é de {filme.Key}.");
                }

                // 4 - A forma mais facil de achar o par é deixar o compilador inferir que essa variável é o par.
                foreach(var filme in filmes) //aqui o compilador já vai inferir que esse filme é do tipo KeyValuePair
                {
                    Console.WriteLine($"{filme.Value} é de {filme.Key}.");
                }
            }
        }
    }
}
