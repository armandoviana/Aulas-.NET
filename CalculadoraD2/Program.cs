using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um ano no formato YYYY: ");
        string anoEntrada = Console.ReadLine();

        if (int.TryParse(anoEntrada, out int ano))
        {
            Console.WriteLine(AnoBissexto(ano) ? $"{ano} é um ano bissexto." : $"{ano} não é um ano bissexto.");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um ano válido no formato YYYY.");
        }
    }

    static bool AnoBissexto(int ano) => (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
}