using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero1, out int numero2)
        {
            numero1 = 0; //tem que ser inicializar a variavel, para passar como referencia.

            numero1 = numero1 + 15;

            numero2 = 0;

            numero2 = numero2 + 30; 
        }
        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            //Diferentemente do ref, o out só recebe um valor, é unilateral, já o ref, é bilateral
            //int b = 2; 
            //int b; o tipO/valor pode ser inicializado na chamada da função 
            AlterarOut( out int b, out int c);
            Console.WriteLine($"{b} - {c}");

            //Utilizar mais o out do que o ref, pode gerar menos bug.
        }
    }
}
