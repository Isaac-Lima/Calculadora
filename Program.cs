using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Potenciação");
            Console.WriteLine("6 - Raiz quadrada");
            Console.WriteLine("7 - Fatorial");
            Console.WriteLine("8 - Sair");

            Console.WriteLine("--------------------");

            Console.Write("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Potenciacao(); break;
                case 6: Radiciacao(); break;
                case 7: Fatorial(); break;
                case 8: System.Environment.Exit(0); break;

                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            double v1 = LerValor("Primeiro valor: ");
            double v2 = LerValor("Segundo valor: ");

            double soma = v1 + v2;

            Console.WriteLine();
            Console.WriteLine($"O resultado da soma é de {soma}");

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            double v1 = LerValor("Primeiro valor: ");
            double v2 = LerValor("Segundo valor: ");

            double resultado = v1 - v2;

            Console.WriteLine();
            Console.WriteLine($"O resultado da subtração é de {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            double v1 = LerValor("Primeiro valor: ");
            double v2 = LerValor("Segundo valor: ");

            if (v2 == 0)
            {
                Console.WriteLine("Erro: Não é possível fazer uma divisão por zero.");
            }
            else
            {
                double resultado = v1 / v2;

                Console.WriteLine();
                Console.WriteLine($"O resultado da divisão é de {resultado}");
            }

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            double v1 = LerValor("Primeiro valor: ");
            double v2 = LerValor("Segundo valor: ");

            double resultado = v1 * v2;

            Console.WriteLine();
            Console.WriteLine($"O resultado da multiplicação é de: {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Potenciacao()
        {
            Console.Clear();

            double v1 = LerValor("Digite a base: ");
            double v2 = LerValor("Digite o expoente: ");

            double resultado = Math.Pow(v1, v2);

            Console.WriteLine();
            Console.WriteLine($"O resultado da potenciação é de {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Radiciacao()
        {
            Console.Clear();

            double v1 = LerValor("Digite o valor para saber sua raiz quadrada: ");

            if (v1 < 0)
            {
                Console.WriteLine("Erro: Raiz quadrada de número negativo não é real.");
            }
            else
            {
                double resultado = Math.Sqrt(v1);

                Console.WriteLine();
                Console.WriteLine($"A raiz quadrada é de {resultado}");
            }

            Console.ReadKey();
            Menu();
        }

        static void Fatorial()
        {
            Console.Clear();

            double v1 = LerValor("Digite um valor para descobrir seu fatorial: ");

            if (v1 < 0)
            {
                Console.WriteLine("Erro: Fatorial de número negativo não é definido.");
            }
            else
            {
                long n_fatorial = 1;
                for (int i = 1; i <= v1; i++)
                {
                    n_fatorial *= i;
                }
                Console.WriteLine();
                Console.WriteLine($"O resultado do fatorial é de {n_fatorial}");
            }

            Console.ReadKey();
            Menu();
        }

        static double LerValor(string mensagem)
        {
            double valor;
            while (true)
            {
                Console.Write(mensagem);
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida, por favor, insira um número.");
                }
            }
            return valor;
        }
    }
}
