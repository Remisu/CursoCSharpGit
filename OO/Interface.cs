using CursoCSharp.OO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    //Criar um interface chamada OperacaoBinaria, eu posso ter varias classes que implementam essa interface.
    interface OperacaoBinaria
    {
        //Os métodos de uma interface são automaticamente Public e Abstract de forma implicita.
        int Operacao(int a, int b); //Apesar de ser um metódo abstrato, não posso colocar a palavra Abstract para um método dentro de uma interface, pq implicitamente ja sao abstract.
    }

    class Soma : OperacaoBinaria
    {
        public int Operacao(int a, int b) //não diminuir a visibilidade, ou seja se colocar protected ali, nao funcionará // nem pode tirar o public se nao vira private.
        {
            return a + b;
        }
    }

    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>()
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";
            foreach (var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }
            return resultado;
        }
    }
}

class Interface
{
    public static void Executar()
    {
        var calc = new Calculadora();
        var resultado = calc.ExecutarOperacoes(20, 5);
        Console.WriteLine(resultado);
    }
}
//Uma classe pode implentar multiplas interfaces, mas só pode implementar um classe
//Sempre que colocar um metodo dentro de uma interface, esse método não pode ter corpo, não pode ter implementação
//Uma classe que decide ser aderante a uma interface, obrigatoriamente precisar implementar os métodos definidos na Interface
//Uma interface pode herdar de outra interface, ou até de multiplas interfaces.
