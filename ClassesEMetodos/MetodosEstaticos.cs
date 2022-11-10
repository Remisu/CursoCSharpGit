using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        //metodo estatico
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        //metodo de instancia
        public int Somar(int a, int b) //Métodos estáticos significam que o método não pertece mais ao objeto, e sim pertece a classe
        {
            return a + b;
        }
    }
    internal class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(3, 4); // chamando um método estático, não precisa criar uma instancia. //Mas vale lembrar que ele tem uma unica copia
            //Se voce precisar tratar de variavel de nomes de clientes por exemplo, vai ter que gerar uma instancia, porque o nome varia de pessoa pra pessoa.
            Console.WriteLine("Resultado é : {0}", resultado);

            CalculadoraEstatica calculadoraEstatica = new CalculadoraEstatica();   //Teve que criar a instancia por nao ser um static
            Console.WriteLine(calculadoraEstatica.Somar(3, 5));
        }
    }
}
