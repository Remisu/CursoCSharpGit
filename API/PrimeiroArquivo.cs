using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;

namespace CursoCSharp.API
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path) //Para substituir o ~ pela Home
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX) //verificar se é Linux ou Mac
                          ? Environment.GetEnvironmentVariable("HOME"): Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%"); //Atribui a variavel de acordo com o sistema op.
            return path.Replace("~", home);
        }
    }

    internal class PrimeiroArquivo
    {
        public static void Executar ()
        {
            //Para caminho de arquivos é importante utilizar o arroba para não sofrer alterações por causa dos caracteres especiais.
            var path = @"~/primeiro_arquivo.txt".ParseHome(); //Utiliza-se o ~ para saber que é a pasta Home do usuário.

            if (!File.Exists (path)) //se o arquivo não existe
            {
                //using somente no if por causa que é importante que a biblioteca se encerre ao terminar de escreve.
                using (StreamWriter sw = File.CreateText(path)) //utilizar o StreamWritter para escrever as coisas dentro do arquivo.
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("Primeiro");
                    sw.WriteLine("Arquivo");
                }
            }
            using (StreamWriter sw = File.AppendText(path)) //utilizar para adicionar mais texto
            {
                sw.WriteLine("");
                sw.WriteLine(" é possivel");
                sw.WriteLine("adicionar mais texto");
            }
        }
    }
}
