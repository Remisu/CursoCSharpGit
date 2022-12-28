using System;
using Encapsulamento; //Nome do namespace colocado dentro do Subcelebridade

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade //preciso colocar a classe SubCelebridade como public, porque ela ta fora do projeto.
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho não Reconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular); //Atributio INTERNAL só acesso, quem ta no mesmo projeto
            Console.WriteLine(JeitoDeFalar); //É um internal e Protected ou seja, ou dentro do mesmo projeto ou por herança (Nessa caso herança)
            //Console.WriteLine(SegredoDeFamilia); //É transmitido por herança apenas dentro do mesmo projeto
            //Console.WriteLine(UsaMuitoPhotoshop);
            Console.WriteLine("\n");
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() 
        {
            Console.WriteLine("Filho não Reconhecido...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho); //Não é recebido por herança, então nao tem acesso.
            //Console.WriteLine(amiga.NumeroCelular); //Atributio INTERNAL só acesso, quem ta no mesmo projeto
            //Console.WriteLine(amiga.JeitoDeFalar); //É um internal e Protected ou seja, ou dentro do mesmo projeto ou por herança (Nessa caso herança)
            //Console.WriteLine(amiga.SegredoDeFamilia); //É transmitido por herança apenas dentro do mesmo projeto
            //Console.WriteLine(amiga.UsaMuitoPhotoshop); 
            Console.WriteLine("\n");
        }
    }

    internal class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
