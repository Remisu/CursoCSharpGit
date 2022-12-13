using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Animal
    {
        //criar um propriedade
        public string Nome { get; set; }

        //definir um construtor que recebe o atributo nome
        public Animal(string nome) 
        { 
            Nome = nome;
        } 
    }

    //criar uma outra classe chamada Cachorro
    public class Cachorro : Animal //classe cachorro herda de animal
    {
        public double Altura { get; set; }  

        
        public Cachorro(string nome) : base(nome) //usou um base pra chamar um construtor da classe pai //um dos construtores tem que chamar o base 
        {
            Console.WriteLine($"Cachorro {nome} foi instanciado/inicializado.");
        }

        //Exemplo de ter um segundo construtor
        public Cachorro(string nome, double altura) : this(nome) //chamando o construtor local da propria classe colocando dois :this
        {
            Altura = altura;
        }

        public override string ToString() //esse metodo é responsável por transformar uma instancia em uma string
        {
            return $"{Nome} tem {Altura} cm de altura!";
        }
    }
    internal class ConstrutorThis
    {
        public static void Executar() 
        {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0);

            Console.WriteLine(spike); //Chamou de forma implícita o ToString
            Console.WriteLine(max); //Se quisesse chamar explicitamente seria (max.ToString)
        }   
    }
}
