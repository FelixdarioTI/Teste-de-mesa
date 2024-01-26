using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Informe o valor atual:");
        double valorAtual = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Informe a taxa de juros (em %):");
        double taxaJuros = double.Parse(Console.ReadLine()) / 100;

        System.Console.WriteLine("Informe o período em meses:");
        int periodoTotal = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Informe o mês do resgate:");
        int mesResgate = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Informe o valor do saque (se houver):");
        double valorSaque = double.Parse(Console.ReadLine());

        System.Console.WriteLine("| PERÍODO |  VALOR ATUAL  | RENDIMENTO LIQ. | REND. ACUMULADO |  SAQUE   | VALOR FINAL |");
        System.Console.WriteLine("|---------|---------------|-----------------|-----------------|----------|-------------|");

        for (int periodo = 0; periodo <= periodoTotal; periodo++)
        {
            double rendimento = valorAtual * taxaJuros;
            double rendimentoLiquido = rendimento - (periodo == mesResgate ? valorSaque : 0);
            double rendimentoAcumulado = valorAtual + rendimento;
            valorAtual = rendimentoAcumulado - (periodo == mesResgate ? valorSaque : 0);

            System.Console.WriteLine($"| {periodo,-7} | {valorAtual,13:C2} | {rendimentoLiquido,15:C2} | {rendimentoAcumulado,15:C2} | {(periodo == mesResgate ? valorSaque : 0),8:C2} | {valorAtual,11:C2} |");

            if (valorAtual <= 0)
                break;
        }
    }
}

