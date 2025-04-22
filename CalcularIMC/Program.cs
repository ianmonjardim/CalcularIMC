using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    namespace CalcularIMC
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Informe o peso em Kg: ");
                double peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a altura em metros: ");
                double altura = double.Parse(Console.ReadLine());

                double imc = peso / (altura * altura);

                Console.WriteLine($"\nIMC = {imc:F2}");

                if (imc < 18.5)
                {
                    Console.WriteLine("Classificação: Abaixo do peso.");
                }
                else if (imc < 25)
                {
                    Console.WriteLine("Classificação: Peso normal.");
                }
                else if (imc < 30)
                {
                    Console.WriteLine("Classificação: Sobrepeso.");
                }
                else if (imc < 35)
                {
                    Console.WriteLine("Classificação: Obesidade Grau I.");
                }
                else if (imc < 40)
                {
                    Console.WriteLine("Classificação: Obesidade Grau II.");
                }
                else
                {
                    Console.WriteLine("Classificação: Obesidade Grau III (mórbida).");
                }

                Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.ReadKey();
            }
        }
    }
}
