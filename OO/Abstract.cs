using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharp.OO.Celular;

namespace CursoCSharp.OO
{
    public abstract class Celular //com abstract não pode instanciar, só pode instanciar classes concretas
    {
        //Método abstrato
        public abstract string Assistente(); //Criar um metodo abstrato sem um corpo, porque quem vai definir é a classe concreta que herda de celular.

        //Método concreto
        public string Tocar()
        {
            return "Trim trim trim...";
        }

        //Quando você tem uma classe abstrata, basicamente você ta falando que a classe está incabada, quem herda essa classe vai ter que implementar os métodos.

        public class Iphone : Celular //Iphone é uma classe concreta então necessariamente precisa implementar
        {
            public override string Assistente()
            {
                return "Ola, meu nome é Siri!";
            }
        }

        public class Samsung : Celular //Iphone é uma classe concreta então necessariamente precisa implementar
        {
            public override string Assistente()
            {
                return "Ola, meu nome é Bixby!";
            }
        }

        //Ou seja, o Iphone eu posso instanciar, o Samsunger eu posso instanciar mas o Celular não porque é uma classe abstrata.
    }
   
    class Abstract
    {
        public static void Executar()
        {
            //Criar uma lista do tipo celular e colocar dentro dela um Iphone e Samsung
            var celulares = new List<Celular>
            {
                new Iphone(),
                new Samsung()

            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
