using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    internal class Polimorfismo
    {
        public class Comida
        {
            public double Peso;

            //Construtor
            public Comida(double peso)
            {
                Peso = peso;
            }

            //Construtor Padrão, se precisar
            public Comida() { }
        }

        public class Feijao : Comida
        {
        }

        public class Arroz : Comida
        {
        }

        public class Carne : Comida
        {
        }

        public class Pessoa
        {
            public double peso;
            //public void Comer(Feijao feijao)
            //{
            //    peso += feijao.Peso;
            //}
            //public void Comer(Arroz arroz)
            //{
            //    peso += arroz.Peso;
            //}
            //public void Comer(Carne carne)
            //{
            //    peso += carne.Peso;
            //}

            //Um unico método que recebe Comida de forma polimorfica, posso passar tipos mais específicos de tipos mais genericos.
            public void Comer(Comida comida)
            {
                peso += comida.Peso;
            }
        }
        public static void Executar()
        {
            Feijao ingrediente1 = new Feijao();
            ingrediente1.Peso = 0.3;

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

            Pessoa cliente = new Pessoa();
            cliente.peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);
            Console.WriteLine($"Agora o peso do cliente é {cliente.peso} Kgs!");

        }
    }
}
