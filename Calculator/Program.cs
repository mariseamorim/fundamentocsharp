using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        { 
            Menu();  
        }

        static void Menu(){
             Console.Clear();
             Console.WriteLine("Bem vindo ao programa de calculadora");
             Console.WriteLine("Operações");
             Console.WriteLine("1- Soma");
             Console.WriteLine("2- Subtração");
             Console.WriteLine("3- Divisão");
             Console.WriteLine("4- Multiplicação");
             Console.WriteLine("0- Sair");
             Console.WriteLine("=====================");
             Console.Write("Escolha a operação:");
             int opcaoMenu = int.Parse(Console.ReadLine());
             decimal v1 = 0;
             decimal v2 = 0;
             if(opcaoMenu == 1 || opcaoMenu == 2 || opcaoMenu == 3 || opcaoMenu == 4 ){
                Console.WriteLine("Primeiro valor:");
                v1 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Segundo valor:");
                v2 = decimal.Parse(Console.ReadLine());
             }
             
             switch (opcaoMenu){
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    Soma(v1,v2);
                    break;
                case 2:
                    Subtracao(v1,v2);
                    break;
                case 3:
                    Divisao(v1,v2);
                    break;
                case 4:
                    Multiplicacao(v1,v2);
                    break;
                default:
                Console.WriteLine("Operação  inválida");
                Console.ReadKey();
                Menu();
                break;

            }
      
        }
        static void Soma(decimal v1, decimal v2){
            decimal resultado = v1 + v2;
            Console.WriteLine(  "===========================================" );
            Console.WriteLine(  $"O resultado da soma é igual a {resultado}." );
            Console.ReadKey();
            Menu();


        }
        static void Subtracao(decimal v1, decimal v2){
            decimal resultado = v1 - v2;
            Console.WriteLine(  "===========================================" );
            Console.WriteLine(  $"O resultado da subtracao é igual a {resultado}." );
            Console.ReadKey();
            Menu();


        }
        static void Divisao(decimal v1, decimal v2){
            decimal resultado = v1 / v2;
            Console.WriteLine(  "===========================================" );
            Console.WriteLine(  $"O resultado da divisao é igual a {resultado}." );
            Console.ReadKey();
            Menu();


        }
         static void Multiplicacao(decimal v1, decimal v2){
            decimal resultado = v1 * v2;
            Console.WriteLine(  "===========================================" );
            Console.WriteLine(  $"O resultado da divisao é igual a {resultado}." );
            Console.ReadKey();
            Menu();

        }
    }
}
