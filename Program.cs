using System;

namespace RevisaoPrincipiosCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação matemática deseja fazer?");
            Console.WriteLine("");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Duvisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("");
            Console.WriteLine("Selecione uma opção: ");
            short operacaoSelecionada = short.Parse(Console.ReadLine());
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

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = primeiroValor / segundoValor;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = primeiroValor * segundoValor;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        }
    }
}
