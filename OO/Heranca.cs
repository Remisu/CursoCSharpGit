using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharp.OO.Carro;

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
        public virtual int Acelerar() //O virtual significa que o metodo pode ser sobrescrito,é o par do "override".
        {
            return AlterarVelocidade(5); //por padrão vou deixar para aumentar de 5 em 5.
        }

        //Metodo publico para frear
        public int Frear()
        {
            return AlterarVelocidade(-5); //por padrão vou deixar para diminuir de 5 em 5.
        }

        //primeira classe que herda de carro
        public class Uno : Carro //quando constrói a classe filho, ele vai buscar o construtor na classe pai, se tiver, se não, terá que classe filho obrigatóriamente
        {
            public Uno() : base (200)  //nao vou passar nenhum parametro mas vou chamar o construtor base, e o construtor base espera receber a velocidade maxima
            {
                
            }
        }

        public class Ferrari : Carro
        {
            public Ferrari() : base(350)
            {

            }
            //Dentro de ferrari vou sobrescrever o metodo Acelerar, porque uma ferrari tem uma aceleração vai rapida.
            public override int Acelerar() //override para sobrescrever um metodo definido na classe pai
            {
                return AlterarVelocidade(15);
            }

            //Oculta o método da classe Pai usando o new
            public new int Frear() //dessa forma não precisa colocar o virtual na classe pai.
            {
                return AlterarVelocidade(-15);
            }
        }
    }
    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("-=-= Uno =-=-");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            //Quando desacelerar e a velocidade supostamente for abaixo de 0, ele nao vai deixar ficar negativo por causa da validação feita anteriormente
            Console.WriteLine(carro1.Frear());
            //Console.WriteLine(carro1.AlterarVelocidade); Esse metodo não está acessível porque está protegido, em outras palavras, ele está encapsulado.

            Console.WriteLine("-=-= Ferrari =-=-");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            //Quando desacelerar e a velocidade supostamente for abaixo de 0, ele nao vai deixar ficar negativo por causa da validação feita anteriormente
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("-=-= Ferrari c/ tipo Carro =-=-");

            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());//ele vai usar o acelerar de ferrari, pq ele sobrescreveu o acelerar de carro +15
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear()); //ele vai frear como um carro normal, pq ele nao sobrescreveu -5
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("-=-= Uno c/ tipo Carro =-=-");
            carro3 = new Uno(); //polimorfismo, ou seja, a mesma variavel assumindo multiplas formas.
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
