using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class TesteOutNum
    {
        public static void Executar()
        {
            string str = "100";
            if (int.TryParse(str, out int num))
            {
                Console.WriteLine("{0}", num + 1);
            }
            else
            {
                Console.WriteLine("A conversão falhou!");
            }

            Console.WriteLine(num);    
        }
    }
}
