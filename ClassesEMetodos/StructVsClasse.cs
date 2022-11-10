using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    //A ideia é criar uma Struct e um Classe que fazem a mesma coisa, e mostra diferença entre os dois

    //Começando pelo Struct
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    //Fazendo a mesma coisa pra classe
    public class CPonto
    {
        public int X;
        public int Y;
    }
    internal class StructVsClasse
    {
        
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3};
            SPonto copiaPonto1 = ponto1; //Atribuição do Valor!!!
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X: {0}", ponto1.X); //3
            Console.WriteLine("Copia do Ponto 1 X: {0}", copiaPonto1.X); //1
            //Isso significa que quando fez a alteração do ponto1, não teve efeito colateral na copia do ponto1.

            CPonto ponto2 = new CPonto { X = 2, Y = 4};
            CPonto copiaPonto2 = ponto2; //Atribuição por Referencia!!
            ponto2.X = 4;

            Console.WriteLine("Ponto 2 X: {0}", ponto2.X);  //4
            Console.WriteLine("Copia do Ponto 2 X: {0}", copiaPonto2.X); //4
            //Isso significa que as duas vão alterar pq apontam pro mesmo local de memória.

            //A forma de atribuição entre Classe e Struct são diferentes.
        }
    }
}
