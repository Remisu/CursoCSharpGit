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

            }
        }
    }
}
