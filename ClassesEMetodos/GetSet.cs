using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca; //por padrão ele é private, mesmo sem colocar no codigo.
        private string Modelo;
        private uint Cilindrada; //uint não permite passar um valor inteiro com sinal

        //Criando o construtor
        public Moto(string marca, string modelo, uint cilindrada)
        {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        //Construtor padrão para fazer qualquer cena
        public Moto()
        {

        }

        //Metodo não convencional de fazer o Get e Set dos atributos
        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca (string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada)
        {
            ////1ª Opção
            //if(cilindrada > 0) //pode definir condição no set
            //{
            //    Cilindrada = cilindrada;
            //}
            
            ////2ª Opção
            //Cilindrada = Math.Abs(cilindrada); //função math para retornar somente valor absoluto, ou seja, valores positivos.

            Cilindrada = cilindrada; 
        }


    }
    internal class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki","Ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca()); //Já não consegue aceder do jeito MOTO1.MARCA, porque lá em cima ta privado.
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();

            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
        }
    }
}
