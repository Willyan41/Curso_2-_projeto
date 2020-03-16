using System;
using System.Globalization;

namespace Curso_2º_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Entre com seu nome completo:
            //            Alex Green
            //Quantos quartos tem na sua casa?
            //3
            //Entre com o preço de um produto:
            //            500.50
            //Entre seu último nome, idade e altura(mesma linha):
            //Green 21 1.73

            string nomeCompleto = Console.ReadLine();
            int quarto = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] frase = Console.ReadLine().Split(' ');
            string nome = frase[0];
            int idade = int.Parse(frase[1]);
            double altura = double.Parse(frase[2]);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quarto);
            Console.WriteLine(valor);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));









        }
    }
}
