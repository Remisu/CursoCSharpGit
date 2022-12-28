using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    internal class Polimorfismo
    {
        public class Feijao
        {
            public double peso;
        }

        public class Arroz
        {
            public double peso;
        }

        public class Carne
        {
            public double peso;
        }

        public class Pessoa
        {
            public double peso;
            public void Comer(Feijao feijao)
            {
                peso += feijao.peso;
            }
            public void Comer(Arroz arroz)
            {
                peso += arroz.peso;
            }
            public void Comer(Carne carne)
            {
                peso += carne.peso;
            }
        }
        public static void Executar()
        {

        }
    }
}
