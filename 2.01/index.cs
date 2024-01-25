using System;

class Program{
    static void Main(string[] args){
        
        double valorPresente = 1000.00;
        
        double taxaJuros = 5.30/100;
        
        int periodoMes = 6;
        
        double percentualJuros = valorPresente * Math.Pow(1 + taxaJuros, periodoMes);
        
        double f = percentualJuros - valorPresente;

        Console.WriteLine($"Valor de início do investimento R$:{valorPresente:C2}");
        Console.WriteLine($"Taxa de Juros adicionada ao valor :{taxaJuros*100}%");
        Console.WriteLine($"Período mensal :{periodoMes}");
        Console.WriteLine($"Rendimento  R$:{f:C2}");
        Console.WriteLine($"Valor final de juros R$:{percentualJuros:C2}");
    }
}