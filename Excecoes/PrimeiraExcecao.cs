using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    public class Conta
    {
       double Saldo;
        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente."); //Lançar uma exceção para o usuário saber exatamente o que aconteceu.
            }
            Saldo -= valor;
        }
    }
    internal class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_223.45);

            //O método sacar é um método que PODE causa um erro, então é interessante usar o TRY.
            try
            {
                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            } 
            //Tratar o erro ou apanhar o erro
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            //Opcional, vai ser executado de qualquer forma.
            finally
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
