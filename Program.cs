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
            Console.WriteLine("5 - Sair");
            Console.WriteLine("");
            Console.WriteLine("Selecione uma opção: ");

            short operacaoSelecionada = short.Parse(Console.ReadLine());

            switch(operacaoSelecionada)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Sair(); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Soma");
            Console.WriteLine("");
            Console.WriteLine("Primeiro Valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = primeiroValor + segundoValor;
            Console.WriteLine($"O Resultado da soma é: {resultado}");

            Console.ReadKey();
            Menu();
        }
        
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Subtração");
            Console.WriteLine("");
            Console.WriteLine("Primeiro Valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = primeiroValor - segundoValor;
            Console.WriteLine($"O Resultado da subtração é: {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Divisão");
            Console.WriteLine("");
            Console.WriteLine("Primeiro Valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = primeiroValor / segundoValor;
            Console.WriteLine($"O resultado da divisão é: {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Multiplicação");
            Console.WriteLine("");
            Console.WriteLine("Primeiro Valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = primeiroValor * segundoValor;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Sair()
        {
            Console.WriteLine("Obrigado! Até a próxima.");
            Environment.Exit(0);
        }

    }

}
