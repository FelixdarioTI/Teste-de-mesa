using System;

class Program
{
    static void Main(string[] args)
    {
        double valorPresente = 2000.00;
        double taxaJurosMes = 0.02;
        double retirada = 0;
        double percentualJuros;

        Console.WriteLine("Digite o mês do resgate:");
        double mes = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o total de meses:");
        double periodo = double.Parse(Console.ReadLine());

        Console.WriteLine("| valor presente  | taxa de juros | periodo de a.m. | rendimento    | renda acumulada | resgate   | total      |");
        Console.WriteLine("|------------------------------------------------------------------------------------------------------------------|");

        for (int periodo = 0; periodo <= periodoTotal; periodo++)
        {
            if (x < mes)
            {
                percentualJuros = valorPresente * Math.Pow(1 + taxaJurosMes, x);
                Console.WriteLine($"| {valorPresente.ToString("C"),-16:C2} | {taxaJurosMes * 100,-13}% | {x,-15} | {(percentualJuros - valorPresente).ToString("C"),-13} | {percentualJuros.ToString("C"),-15} | {retirada.ToString("C"),-9} | {percentualJuros.ToString("C"),-9} |");
            }
            else if (x == mes)
            {
                Console.WriteLine("Digite o valor de retirada:");
                double valorRetirada = double.Parse(Console.ReadLine());
                retirada = valorRetirada;
                double rendimentoAntesDoResgate = valorPresente * Math.Pow(1 + taxaJurosMes, x - 1);
                percentualJuros = rendimentoAntesDoResgate * (1 + taxaJurosMes);
                valorPresente = percentualJuros - retirada;
                Console.WriteLine($"| {rendimentoAntesDoResgate.ToString("C"),-16:C2} | {taxaJurosMes * 100,-13}% | {x,-15} | {(percentualJuros - rendimentoAntesDoResgate).ToString("C"),-13} | {percentualJuros.ToString("C"),-15} | {retirada.ToString("C"),-9} | {valorPresente.ToString("C"),-9} |");
            }
            else if (x > mes)
            {
                percentualJuros = valorPresente * Math.Pow(1 + taxaJurosMes, x - mes);
                Console.WriteLine($"| {valorPresente.ToString("C"),-16:C2} | {taxaJurosMes * 100,-13}% | {x,-15} | {(percentualJuros - valorPresente).ToString("C"),-13} | {percentualJuros.ToString("C"),-15} | {retirada.ToString("C"),-9} | {percentualJuros.ToString("C"),-9} |");
            }
        }
    }
}

