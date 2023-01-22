using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class DelegateFuncAnonima
    {
        //Criei o meu delegate que retorna uma string e recebe uma string.
        delegate string StringOperacao(string s);

        public static void Executar()
        {
            StringOperacao inverter = delegate (string s) //Uma vez tendo o delegate eu posso criar uma variavel do tipo StringOperacao, que foi passado um delegate associado a uma função anonima
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine("Digite uma palavra: \n");
            string palavra = Console.ReadLine();
            Console.WriteLine(inverter(palavra));
        }
    }
}
