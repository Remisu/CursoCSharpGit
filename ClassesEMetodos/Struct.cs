using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    interface Ponto
    //sintaxe parecida com a da classe, só que ao invés de criar funções que tenham um  corpo, só cria a assinatura da função
    //quem tiver aderente a essa interface, vai ter que ter a mesma assinatura da interface, classe tbm... anyway, não entendi
    {
        void MoverNaDiagonal(int Delta); //mover uma interface chamada Ponto
    }

    struct Coordenada : Ponto //Essa struct vai precisar ser aderente a interface ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }
    internal class ExemploStruct
    {
        public static void Executar()
        {
            Coordenada coordenadainicial;
            coordenadainicial.X = 2;
            coordenadainicial.Y = 2;

            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X = {0}", coordenadainicial.X);
            Console.WriteLine("Y = {0}", coordenadainicial.Y);

            var coordenadaFinal = new Coordenada(x:9, y:1);
            coordenadaFinal.MoverNaDiagonal(10); //Vai somar em 10 no eixo X e somar em 10 no eixo Y.
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);
        }

        //Struct e Classes são MUITO parecidos.
    }
}
