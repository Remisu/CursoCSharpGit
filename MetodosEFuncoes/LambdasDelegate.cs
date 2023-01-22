using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class LambdasDelegate
    {
        //Delegate você definir um tipo que armazena uma assinatura de uma função
        //Essa assinatura consegue criar uma variavel do tipo do delegate e criar um função com o tipo da assinatura

        delegate double Operacao(double x, double y); //Criando um tipo, chamado operação
        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;
            Console.WriteLine(sum(3,3));
            Console.WriteLine(sub(5,2));
            Console.WriteLine(mult(12,8));
        }
    }
}
