using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento; //readonly faz com que ele seja imutável, só pode ser settado uma vez, pode alterar somente no construtor



        //criar o construtor
        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;

            //Nascimento = new DateTime(2022, 10, 10); //Se settar esse valor no construtor, vai ser esse independente se no Executar vai estar settando, por causa do readonly
        }

        //metodo getdatadenascimento
        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }

    }

    class ReadOnly
    {
        public static void Executar() 
            //public = pode ser acessado de outros namespaces
            //static = Eu não preciso criar um objetivo pra executar a função Executar
            //void = a Função Executar não retorna nada
            //Poderia ser Static Public Void sem problema, mas o Void tem que ser sempre o ultimo.
        {
            //criar uma instancia de cliente
            var novoCliente = new Cliente("Ana Silva", new DateTime(1995,8,14));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

        }
    }
}
