using System;
using System.IO;

namespace TextEditor
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
            Console.WriteLine("Bem vindo escolha uma opção de menu!");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar arquivo");
            Console.WriteLine("0 - Sair");

            short opcao = short.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    Abrir();
                    break;
                case 2:
                    Criar();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    Menu();
                    break;

            }

        }
        static void Abrir()
        {
           Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
        static void Criar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("=============================");
            string texto = "";
            do{
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while(Console.ReadKey().Key  != ConsoleKey.Escape);
            
           
            Salvar(texto);

        }
        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path =  Console.ReadLine();
        
            // Abre e fecha automaticamente o objeto(arquivo)
            using(var file = new StreamWriter(path))
            {
                file.Write(texto);
            }
            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();
           
        }
    }
}
