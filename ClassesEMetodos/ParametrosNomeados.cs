using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2:D2}",dia,mes,ano); //D2 para ficar com duas casas decimais.
        }
        public static void Executar()
        {
            Formatar(ano: 1995,dia: 14, mes: 8 ); //Alterei a ordem da chamada
        }
    }
}
