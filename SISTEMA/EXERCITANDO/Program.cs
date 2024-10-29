using System;
using System.Threading;

namespace Aula2exercisios
{
    public class Program
    {
        static void Main(string[] args)
        {
            exibir_cabecalho();
            exibir_opcoes_menu();
        }

        public static void exibir_cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**************");
            Console.WriteLine("Projeto de Exercícios");
            Console.WriteLine("Autor: Matheus Ismarsi");
            Console.WriteLine("**************");
            Console.ResetColor();
            Console.WriteLine(@"
███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗████████╗░█████╗░███╗░░██╗██████╗░░█████╗░
██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║╚══██╔══╝██╔══██╗████╗░██║██╔══██╗██╔══██╗
█████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║░░░██║░░░███████║██╔██╗██║██║░░██║██║░░██║
██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║░░░██║░░░██╔══██║██║╚████║██║░░██║██║░░██║
███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║░░░██║░░░██║░░██║██║░╚███║██████╔╝╚█████╔╝
╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░");
            Console.WriteLine("\nSeja bem-vindo ao sistema de exercícios!");
        }

        public static void exibir_opcoes_menu()
        {
            Console.WriteLine("\nMenu de Opções:");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Exercício 1");
            Console.WriteLine("2 - Exercício 2");
            Console.WriteLine("3 - Exercício 3");
            Console.WriteLine("4 - Exercício 4");
            Console.WriteLine("5 - Exercício 5");
            Console.WriteLine("6 - Exercício 6");
            Console.Write("\nDigite a opção escolhida: ");

            int opcao_escolhida = int.Parse(Console.ReadLine());

            switch (opcao_escolhida)
            {
                case 0:
                    Sair();
                    break;
                case 1:
                    executar_exercisio(1);
                    break;
                case 2:
                    executar_exercisio(2);
                    break;
                case 3:
                    executar_exercisio(3);
                    break;
                case 4:
                    executar_exercisio(4);
                    break;
                case 5:
                    executar_exercisio(5);
                    break;
                case 6:
                    executar_exercisio(6);
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    exibir_cabecalho();
                    exibir_opcoes_menu();
                    break;
            }
        }

        private static void executar_exercisio(int numero_exercisio)
        {
            Console.Clear();
            Console.WriteLine($"Exercício {numero_exercisio}");
            Console.WriteLine($"Executando o exercício {numero_exercisio}...\n");

            // Aqui você coloca a lógica específica para cada exercício
            switch (numero_exercisio)
            {
                case 1:
                    exercisio1();
                    break;
                case 2:
                    exercisio2();
                    break;
                case 3:
                    exercisio3();
                    break;
                case 4:
                    exercisio4();
                    break;
                case 5:
                    exercisio5();
                    break;
                case 6:
                    exercisio6();
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
            exibir_cabecalho();
            exibir_opcoes_menu();
        }

        private static void exercisio1()
        {
            Console.WriteLine("Conteúdo do Exercício 1.");
            // Lógica do Exercício 1
        }

        private static void exercisio2()
        {
            Console.WriteLine("Conteúdo do Exercício 2.");
            // Lógica do Exercício 2
        }

        private static void exercisio3()
        {
            Console.WriteLine("Conteúdo do Exercício 3.");
            // Lógica do Exercício 3
        }

        private static void exercisio4()
        {
            Console.WriteLine("Conteúdo do Exercício 4.");
            // Lógica do Exercício 4
        }

        private static void exercisio5()
        {
            Console.WriteLine("Conteúdo do Exercício 5.");
            // Lógica do Exercício 5
        }

        private static void exercisio6()
        {
            Console.WriteLine("Conteúdo do Exercício 6.");
            // Lógica do Exercício 6
        }

        private static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Encerrando o programa...");
            Console.WriteLine(@"
░██████╗░█████╗░██╗███╗░░██╗██████╗░░█████╗░░░░░░░░░░
██╔════╝██╔══██╗██║████╗░██║██╔══██╗██╔══██╗░░░░░░░░░
╚█████╗░███████║██║██╔██╗██║██║░░██║██║░░██║░░░░░░░░░
░╚═══██╗██╔══██║██║██║╚████║██║░░██║██║░░██║░░░░░░░░░
██████╔╝██║░░██║██║██║░╚███║██████╔╝╚█████╔╝██╗██╗██╗
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░╚═╝╚═╝╚═╝");
            Thread.Sleep(3000);
        }
    }
}
