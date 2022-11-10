using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Outros
{
    internal class ContarSequenciaDeLetras
    {
        public static void Executar()
        {
            int contador = 1;
            char CatacterAtual;
            string ResultadoParcial = null;
            string Resultado = null;


            Console.WriteLine("Digita a palavra desejada:");
            string palavra = Console.ReadLine();
            palavra = palavra + ' ';

            for (int i = 0; i < palavra.Length && palavra[i] != ' '; i++)
            {
                    CatacterAtual = palavra[i];

                    while (palavra[i] == palavra[i + contador] && palavra[i] == CatacterAtual && palavra[i + contador] !=  ' ')
                    {
                    contador++;
                        ResultadoParcial = palavra[i] + Convert.ToString(contador);
                        Console.WriteLine(ResultadoParcial);
                    }
                i = i + (contador-1); //Modificar o contador do FOR para pular para a próxima letra
                contador = 1; //Reset do contador para a próxima letra

                Resultado = Resultado + ResultadoParcial;
            }
            Console.WriteLine("A sequencia de letras da palavra é: " + Resultado );
        }
    }
}
