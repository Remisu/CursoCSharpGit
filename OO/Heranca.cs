using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    //criar uma nova classe
    public class Carro
    {
        //definir atributos
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        //construtores de carro
        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        //metodo protegido para alterar a velocidade
        protected int AlterarVelocidade(int delta) //metodo protegido para ser mexido somente por classes de herdam de Carro, ou seja, por herança.
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) //não deixar a velocidade ser negativa.
            {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) //não deixar a velocidade ser maior que a velocidade máxima.
            {
                VelocidadeAtual = VelocidadeMaxima;
            } else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        //Metodo publico para acelerar
        public int Acelerar() 
        {
            return AlterarVelocidade(5); //por padrão vou deixar para aumentar de 5 em 5.
        }

        //Metodo publico para frear
        public int Frear()
        {
            return AlterarVelocidade(-5); //por padrão vou deixar para diminuir de 5 em 5.
        }

        //primeira classe que herda de carro
        public class Uno : Carro //quando constrói a classe filho, ele vai buscar o construtor na classe pai, se tiver, se não, terá que fazer.
        {

        }
    }
    internal class Heranca
    {
        public static void Executar()
        {

        }
    }
}
