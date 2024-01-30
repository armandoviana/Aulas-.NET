using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha uma operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        Console.Write("Opção: ");
        string escolha = Console.ReadLine();

        if (escolha != "1" && escolha != "2" && escolha != "3" && escolha != "4")
        {
            Console.WriteLine("Opção inválida. O programa será encerrado.");
            return; 
        }

        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = 0;

        switch (escolha)
        {
            case "1":
                resultado = num1 + num2;
                break;
            case "2":
                resultado = num1 - num2;
                break;
            case "3":
                resultado = num1 * num2;
                break;
            case "4":
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
            break;
        }

        Console.WriteLine($"Resultado: {resultado}");
    }
}