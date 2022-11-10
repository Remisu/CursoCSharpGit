using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>(); //Atribuindo uma fila a uma variável, e amarrando para que todos elementos sejam to tipo STRING.

            fila.Enqueue("Fulano");//Adicionar um item na fila, ou seja, enfileirar.
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek()); //O peek vai pegar o que ta mais próximo da fila.
            Console.WriteLine(fila.Count()); //Vai fazer o count de quantos items tem na fila.

            Console.WriteLine(fila.Dequeue()); //O dequeue vai retirar um objeto da fila.
            Console.WriteLine(fila.Count());

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);  
            }

            //Criar uma outra fila, mas essa não usa o generics, ou seja, que aceite diferentes tipos de dados.
            var salada = new Queue(); //tem que la em cima adicionar o using System.Collections;

            //Adicionando diferentes tipos na lista
            salada.Enqueue(3);
            salada.Enqueue("Tomate");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("Tomate")); //Contains verifica se existe na fila um item com a nomeclatura que eu colocar no Contains. (Vai retornar true)
            Console.WriteLine(salada.Contains("tomate")); // (Vai retornar false pq ta com o T minusculo)

        }
    }
}
