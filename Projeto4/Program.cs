using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Manuelaalfapt4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            funcionario  Func =  new funcionario();

            Console.Write("None: ");
            Func.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            Func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            Func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario : " + Func);

            Console.Write("Digite a porcetagem para aumentar o salario:");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Func.AumentoSalario(porcent);

            Console.WriteLine("Dados  atualizados: " + Func);
        }
    }
}
