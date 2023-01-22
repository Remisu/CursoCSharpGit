using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    sealed class SemFilho //Uma classe que não permite herança
    {
        public double  ValorDaFortuna()
        {
            return 1_407_033.65;
        }
    }

    //class SouFilho : SemFilho 
    //{

    //}

    class Avo
    {
        public virtual bool HonrarNomeFamilia() //virtual permite a sobrescrita e o selead nao permite a sobrescrita
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool HonrarNomeFamilia() //Todo mundo que estiver abaixo de pai, vai herder o true de honrar a familia
        {
            return true;
        }
    }

    class FilhoRebelde : Pai //Nao pode sobescrever o true do honrar familia.
    {
        //public override bool HonrarNomeFamilia()
        //{
        //    return false;
        //}
    }
    class Sealed
    {
        public static void Executar()
        {
            SemFilho semfilho = new SemFilho();
            Console.WriteLine(semfilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
