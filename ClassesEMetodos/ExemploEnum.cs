using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia}; //Elementos de uma enumeração
    public class Filme //Criar classe
    {
        public string Titulo; //Atributo 1
        public Genero GeneroDoFilme; //Atributo 2
    }
    internal class ExemploEnum
    {
        public static void Executar()
        {
            //1a forma de acessar um enum
            int id = (int)Genero.Animacao; //cast de genero.animacao transformado para inteiro
            Console.WriteLine(id); //Vai exibir o "3", que o indice dele na enumeração.

            //proximo exemplo - Criando um novo filme
            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "No One's Ark";
            filmeParaFamilia.GeneroDoFilme = Genero.Aventura; //só consigo atribuir uma enumeração, que é um valor fechado já predefinido

            Console.WriteLine("{0} é {1}!",filmeParaFamilia.Titulo,filmeParaFamilia.GeneroDoFilme);
        }
    }
}
