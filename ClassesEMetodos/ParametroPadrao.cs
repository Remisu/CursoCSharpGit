using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametroPadrao
    {
        public static int Somar(int a = 1, int b = 1)//Valor padrão, caso não informe o valor, vai receber o valor 1
        {
            return a + b;
        }

        public static void Executar()
        {
            Console.WriteLine(Somar(10,23)); //passando os dois valores, vai dar 10+23 = 33
            Console.WriteLine(Somar(50)); //passando somente 1 valor , vai dar 50+1 = 51 (porque 1 já está na int b como valor padrão)
            Console.WriteLine(Somar()); //passando nenhum valor, vai dar 2, pois tem os dois valores padrão como 1.
            Console.WriteLine(Somar(b: 7)); //passando somente o segundo valor, vai dar 8, pois ja tem o valor padrão como 1.
        }
    }
}
