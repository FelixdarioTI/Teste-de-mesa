using System;

class Program{
    static void Main(string[] args){
        
         Console.WriteLine("Digite o valor Inicial:");
         double valorPresente = double.Parse(Console.ReadLine());
         Console.WriteLine("Digite a taxa em juros:");
         double taxaJuros = double.Parse(Console.ReadLine());
         Console.WriteLine("Digite o período em anos:");
         double periodoAnos = double.Parse(Console.ReadLine());
        
        double percentualJuros = valorPresente * Math.Pow(1 + taxaJuros, periodoAnos);
        
        double f = percentualJuros - valorPresente;

        Console.WriteLine($"Valor de início do investimento R$:{valorPresente:C2}");
        Console.WriteLine($"Taxa de Juros adicionada ao valor :{taxaJuros*100}%");
        Console.WriteLine($"Período mensal :{periodoAnos}");
        Console.WriteLine($"Rendimento  R$:{f:C2}");
        Console.WriteLine($"Valor final de juros R$:{percentualJuros:C2}");
        
    }
}