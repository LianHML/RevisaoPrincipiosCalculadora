using System;

namespace RevisaoPrincipiosCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = primeiroValor + segundoValor;
            Console.WriteLine($"O Resultado da soma é: {resultado}");
        }
        
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = primeiroValor - segundoValor;
            Console.WriteLine($"O Resultado da subtração é: {resultado}");
        }
    }
}
