using System;

class Ex9
{
    static void Main()
    {
        Console.Write("Digite o primeiro texto: ");

        string texto1 = Console.ReadLine() ?? "";

        Console.Write("Digite o segundo texto: ");

        string texto2 = Console.ReadLine() ?? "";

        // Mostrar tamanho
        Console.WriteLine($"Tamanho do primeiro texto: {texto1.Length}");
        Console.WriteLine($"Tamanho do segundo texto: {texto2.Length}");

        // Em letras maiúsculas
        string texto1Maiusculo = texto1.ToUpper();

        string texto2Maiusculo = texto2.ToUpper();

        Console.WriteLine($"Primeiro texto (maiúsculo): {texto1Maiusculo}");
        Console.WriteLine($"Segundo texto (maiúsculo): {texto2Maiusculo}");

        // Comparação
        int resultadoComparacao = string.Compare(texto1Maiusculo, texto2Maiusculo);

        // Se for equivalentes
        if (resultadoComparacao == 0)
        {
            Console.WriteLine("Os textos são equivalentes!");
        }
        else
        {
            Console.WriteLine("Os textos são diferentes.");
        }
    }
}
