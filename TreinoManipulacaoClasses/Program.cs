using System;

namespace TreinoManipulacaoClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa tchola = new Pessoa(); 
            tchola.FazerMedia();
            tchola.MostrarNaTela();
            tchola.VerAprovacao();
            Console.ReadKey();
        }
    }
}
