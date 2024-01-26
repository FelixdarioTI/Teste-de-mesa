using System;

class Program{
    static void Main(string[] args){
        
         System.Console.WriteLine("Digite o valor Inicial:");
         double valorPresente = double.Parse(Console.ReadLine());
         System.Console.WriteLine("Digite a taxa em juros:");
         double taxaJuros = double.Parse(Console.ReadLine());
         System.Console.WriteLine("Digite o período em anos:");
         double periodoAnos = double.Parse(Console.ReadLine());
        
        double percentualJuros = valorPresente * Math.Pow(1 + taxaJuros, periodoAnos);
        
        double f = percentualJuros - valorPresente;

        System.Console.WriteLine($"Valor de início do investimento R$:{valorPresente:C2}");
        System.Console.WriteLine($"Taxa de Juros adicionada ao valor :{taxaJuros*100}%");
        System.Console.WriteLine($"Período mensal :{periodoAnos}");
        System.Console.WriteLine($"Rendimento  R$:{f:C2}");
        System.Console.WriteLine($"Valor final de juros R$:{percentualJuros:C2}");
        
    }
}