using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesArrayList
    {
        public static void Executar()
        {
            //NÃO É UMA FORMA MUITO UTILIZADA PORQUE INVOLVE DIFERNETES TIPOS DE DADOS EM UMA LISTA
            var arraylist = new ArrayList
            {
                "Palavra", //string (que é um classe)
                3,         //inteiro (que é uma struct)
                true,      //boolena (que tbm vem de scruct)
                'E'        //char (que tbm é struct)
            };

            arraylist.Add(3.456);

            foreach (var item in arraylist)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType());    
            }
        }
    }
}
