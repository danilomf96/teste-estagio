using System;

class Program
{
    static void Main()
    {
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("Escolha um exercício:");
            Console.WriteLine("1 - Soma até um número (K)");
            Console.WriteLine("2 - Verificar se um número está na sequência de Fibonacci");
            Console.WriteLine("3 - Faturamento diário (menor, maior e dias acima da média)");
            Console.WriteLine("4 - Percentual de faturamento por estado");
            Console.WriteLine("5 - Inverter uma string");
            Console.WriteLine("0 - Sair");

            Console.Write("Digite sua escolha: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    SomaDeK();
                    break;
                case 2:
                    Fibonacci();
                    break;
                case 3:
                    FaturamentoDiario();
                    break;
                case 4:
                    PercentualFaturamento();
                    break;
                case 5:
                    InverterString();
                    break;
                case 0:
                    continuar = false;
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente de novo.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void SomaDeK()
    {
        int indice = 13, soma = 0, k = 0;

        while (k < indice)
        {
            k++;
            soma += k;
        }

        Console.WriteLine($"A soma total é: {soma}");
    }

    static void Fibonacci()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        bool pertence = PertenceFibonacci(numero);
        if (pertence)
        {
            Console.WriteLine($"O número {numero} está na sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO está na sequência de Fibonacci.");
        }
    }

    static bool PertenceFibonacci(int num)
    {
        int a = 0, b = 1, c = 0;

        while (c < num)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c == num || num == 0;
    }

    static void FaturamentoDiario()
    {
        double[] faturamento = { 22174.16, 24537.66, 26139.61, 0.0, 0.0, 26742.66, 0.0 };

        double menor = double.MaxValue;
        double maior = double.MinValue;
        double soma = 0;
        int diasValidos = 0;

        foreach (double valor in faturamento)
        {
            if (valor > 0)
            {
                if (valor < menor) menor = valor;
                if (valor > maior) maior = valor;
                soma += valor;
                diasValidos++;
            }
        }

        double media = soma / diasValidos;
        int diasAcimaDaMedia = 0;

        foreach (double valor in faturamento)
        {
            if (valor > media)
            {
                diasAcimaDaMedia++;
            }
        }

        Console.WriteLine($"Menor faturamento: {menor}");
        Console.WriteLine($"Maior faturamento: {maior}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
    }

    static void PercentualFaturamento()
    {
        double SP = 67836.43, RJ = 36678.66, MG = 29229.88, ES = 27165.48, Outros = 19849.53;
        double total = SP + RJ + MG + ES + Outros;

        Console.WriteLine($"SP: {(SP / total) * 100:F2}%");
        Console.WriteLine($"RJ: {(RJ / total) * 100:F2}%");
        Console.WriteLine($"MG: {(MG / total) * 100:F2}%");
        Console.WriteLine($"ES: {(ES / total) * 100:F2}%");
        Console.WriteLine($"Outros: {(Outros / total) * 100:F2}%");
    }

    static void InverterString()
    {
        Console.Write("Digite uma string: ");
        string texto = Console.ReadLine();

        char[] caracteres = new char[texto.Length];
        for (int i = 0; i < texto.Length; i++)
        {
            caracteres[i] = texto[texto.Length - 1 - i];
        }

        string invertida = new string(caracteres);
        Console.WriteLine($"String invertida: {invertida}");
    }
}
