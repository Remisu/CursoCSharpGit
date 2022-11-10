using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome; //O string por padrão ele é um classe, case você aperte F12 nele, ou seja, atribuição por referencia
        public int Idade; //O int por padrão é um struct, caso você aperte F12 nele, ou seja, atribuição por valor.
    }


    internal class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($" Numero: {numero} - Copia: {copiaNumero}");

            numero++;
            Console.WriteLine($"Após o numero++ ficou como Numero: {numero} - Copia: {copiaNumero}");

            //criar um classe
            Dependente dep = new Dependente
            {
                Nome = "Emerson",
                Idade = 27
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"Nome : {dep.Nome} / Idade: {dep.Idade}");
            Console.WriteLine($"Nome Copia : {copiaDep.Nome} / Idade Copia: {copiaDep.Idade}");

            //Fazer um alteração pra ver o que vai mudar
            copiaDep.Nome = "Remisu";
            dep.Idade = 21;
            Console.WriteLine($"Alterei  a copia do nome pra Remisu e o depIdade para 21");
            Console.WriteLine($"Nome : {dep.Nome} / Idade: {dep.Idade}");
            Console.WriteLine($"Nome Copia : {copiaDep.Nome} / Idade Copia: {copiaDep.Idade}");
        }
    }
}
