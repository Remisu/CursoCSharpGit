using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () => //Action recebe algonoconsole, vai receber os parametros que vao estar nos parenteses e a seta para dizer que logo depois vai ter a função.
            {
                Console.WriteLine("Lambda com C#!"); //Lambda é um conceito de função anonima, que é a armazenada numa variável. A função é o que ta depois do .. algo no console =...
                //Action é uma função que não tem retorno, é uma função Void. Depois vamos ver o func e o func tem retorno.
            };

            algoNoConsole();

            //Criar uma func que vai retornar um valor inteiro como repsosta, dentro do <> é o tipo de retorno que vai ter a função.
            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            //Nessa func vai ser uma string que recebe como parametro um inteiro.
            //Func<parametro que recebe, tipo de retorno> nome da variavel = parametro que recebe => setença de codigo que será executada
            Func<int, string> ConversorHex = numero => numero.ToString("X"); //Se tivesse entre os parenteses no final, teria que ter o return, mas como nao tem, fica implicito.
            Console.WriteLine(ConversorHex(1234));

            //Uma func que vai receber 3 inteiros e via retornar uma string
            Func<int, int, int, string> formatarData = (dia, mes, ano) => //como nao colocou corpo, implicitamente há um return
                string.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(14,08,1995));
            
        }
    }
}
