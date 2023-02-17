using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    //IDEIA : GERAR UM NUMERO ALEATORIO ENTRE -30 E 30, E EU SÓ VOU QUERER NUMERO POSITIVO E PAR.
    public class NegativoException : Exception //Criei uma nova classe que herda de exception (herança)
    {
        //Defini mais ou menos os construtores para conseguir usar o que foi definido no exception.
        public NegativoException() { }

        public NegativoException(string message) : base(message) { }

        public NegativoException(string message, Exception inner) : base(message, inner) { }
    }

    public class ImparException : Exception //Criei uma nova classe que herda de exception (herança)
    {
        public ImparException(string message) : base(message) { }
    }

    internal class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor < 0)
            {
                throw new NegativoException(valor + " é um número negativo... ");
            }
            if (valor % 2 == 1)
            {
                throw new ImparException(valor + " é um número impar...");
            }

            return valor; //se ele passar pelas duas exceções significa que é um valor par e positivo.
        }

        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            }
            catch (NegativoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ImparException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}