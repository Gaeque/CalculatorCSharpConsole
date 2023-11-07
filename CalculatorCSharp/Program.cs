using System;
using System.Collections;

namespace Calculator
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
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine($"\tBem vindo a Calculadora \nQual Operação matemática gostaria de fazer?");
      Console.WriteLine("\t1 - SOMA \n\t2 - SUBTRAÇÃO \n\t3 - MULTIPLICAÇÃO \n\t4 - DIVISÃO \n\t5 - SAIR DA CALCULADORA");
      Console.WriteLine("----------------------------------------------");

      ConsoleKeyInfo keyInfo = Console.ReadKey();

      switch (keyInfo.KeyChar)
      {
        case '1': Soma(); break;
        case '2': Subtracao(); break;
        case '3': Multiplicacao(); break;
        case '4': Divisao(); break;
        case '5': System.Environment.Exit(0); break;
        default: Menu(); break;
      }

      Console.WriteLine($"\nPressione 'S' para realizar outra operação \nPressione 'N' para sair da calculadora");
      ConsoleKeyInfo keyExit = Console.ReadKey();

      switch (keyExit.KeyChar)
      {
        case 's': Menu(); break;
        case 'n': Environment.Exit(0); break;
      }

    }

    static void Soma()
    {
      Console.Clear();
      Console.WriteLine("Escolha um número para fazer a Soma");
      float number1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Diga um outro número");
      float number2 = float.Parse(Console.ReadLine());
      Console.Clear();
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine($"A soma do {number1} + {number2} é igual a: {number1 + number2}");
      Console.WriteLine("----------------------------------------------");


    }

    static void Subtracao()

    {
      Console.Clear();
      Console.WriteLine("Escolha um número para fazer a Subtração");
      float number1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Diga um outro número");
      float number2 = float.Parse(Console.ReadLine());
      Console.Clear();
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine($"A Subtração de {number1} - {number2} é igual a: {number1 - number2}");
      Console.WriteLine("----------------------------------------------");

    }

    static void Multiplicacao()
    {
      Console.Clear();
      Console.WriteLine("Escolha um número para fazer a Multiplicação");
      float number1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Diga outro número");
      float number2 = float.Parse(Console.ReadLine());
      Console.Clear();
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine($"A Multiplicação de {number1} * {number2} é igual a: {number1 * number2}");
      Console.WriteLine("----------------------------------------------");


    }
    static void Divisao()
    {
      Console.Clear();
      Console.WriteLine("Escolha um número para fazer a Divisão");
      float number1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Diga um outro número");
      float number2 = float.Parse(Console.ReadLine());
      Console.Clear();
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine($"a Divisão de {number1} / {number2} é igual a: {number1 / number2}");
      Console.WriteLine("----------------------------------------------");
    }
  }
}