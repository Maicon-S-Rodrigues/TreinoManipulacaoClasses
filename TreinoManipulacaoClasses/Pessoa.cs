using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoManipulacaoClasses
{
    internal class Pessoa
    {

        string Nome;
        string Apelido;
        int Idade;
        float Nota1;
        float Nota2;
        float Media;

        public Pessoa ()
        {
            Console.WriteLine("Qual o nome? ");
            this.Nome = Console.ReadLine();
            Console.WriteLine("E qual o apelido? ");
            this.Apelido = Console.ReadLine();
            Console.WriteLine("Quantos anos?");
            this.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto ele(a) tirou na primeira nota?");
            this.Nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("E qual foi a segunda nota?");
            this.Nota2 = float.Parse(Console.ReadLine());
        }


        public void FazerMedia ()
        {
            this.Media = (this.Nota1 + this.Nota2) / 2;
        }

        public void VerAprovacao ()
        {
            if (this.Media > 5)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                if (this.Media == 5)
                {
                    Console.WriteLine("RECUPERAÇÃO");
                }
                else
                {
                    Console.WriteLine("REPROVADO");
                }
            }
        }

        public void MostrarNaTela ()
        {
            Console.WriteLine("\nNome: " + this.Nome + "\nApelido: " + this.Apelido + "\nIdade: " + this.Idade +
                              "\nNota 1: " + this.Nota1 + "\nNota 2: " + this.Nota2 + "\nMédia das Notas: " + this.Media + "\n\nSituação: ");
        }
    }
}
