using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class DelegatesComoParametros
    {
        //Criar um delegate que vai retornar um inteiro e vai receber como parametro int x e int x
        public delegate int Operacao(int x, int y);

        //Criar uma função que vai estar aderente a esse delegate
        public static int Soma(int x, int y)
        {
            return x + y;
        }
        
        //Criar uma função que vai receber como parametro uma função do tipo delegate
        public static string Calculadora(Operacao op,int x, int y)
        {
            var resultado = op(x, y);
            return "Resultado :" + resultado;
        }
        public static void Executar()
        {
            //Operacao usando o lambda
            Operacao subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(subtracao,3,2));
            Console.WriteLine(Calculadora(Soma,3,2));

        }
    }
}
