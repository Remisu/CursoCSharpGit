using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5]; //criar um array do tipo String chamada Alunos, com 5 posições.
            //Array é uma estrutura homegena, ou seja, não se pode ter diferntes tipos de variaveis.             -São todas do mesmo tipo
            //Array é um estrutura estática ela não cresce no momento que você vai colocando elementos nela.     -Não cresce
            //Array é um estrutura indexada, acessa os elementos a partir de um índice, [0]..[1]..[2]..[3]..

            //Formas de setar valor em array
            alunos[0] = "Emerson";
            alunos[1] = "Guilherme";
            alunos[2] = "Jonas";
            alunos[3] = "Iann";
            alunos[4] = "Will";
            //Alunos[5] = "Matheus"; //Na hora de executar vai dar erro por o index ta além do esperado, um indice que nao existe.

            //Pode se criar array de um objeto
            //Não pode acessar o array pelo nome

            foreach(var aluno in alunos) //foreach é uma boa estrutura de reptição para percorrer um array.
            {
                Console.WriteLine(aluno);
            }

            //Testar apanhar um conjunto de notas, calcular uma média e armazenar num array
            double somatorio = 0; //inicializando a variavel
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 }; //adicionando as notas manualmente //tamanho de 5 elementos

            foreach(var nota in notas) //percorrendo cada nota
            {
                somatorio += nota; //fazendo o soma das notas em somatorio
            }

            double media = somatorio / notas.Length; //dividindo o somatorio com o tamanho do array atraves do Lenght
            Console.WriteLine(media);

            ////Outra forma de acessar o array
            //for (int i = 0; i < notas.Length; i++)
            //{
            //    somatorio += notas[i];
            //}


            //criando um array de letras
            char[] letras = { 'A', 'r', 'r', 'a', 'y' }; //tamanho de 5 elementos

            //posso criar um string usando array de letras
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
