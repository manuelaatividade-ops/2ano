using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace manuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa");
            Console.WriteLine("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            int diferenca;
            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
                diferenca = p1.idade - p2.idade;
                Console.Write("A diferença entre eles é: "+diferenca);
            }
        else
            {
                Console.WriteLine("Pessoa mais velha:  "+p2.nome);
                diferenca = p2.idade;
                Console.Write("A diferença entre eles é: ");
            }
        }
    }
}
