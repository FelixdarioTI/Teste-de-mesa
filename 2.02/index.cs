using System;

class Program{
    static void Main(string[] args){
        
        double valorPresente = 3800.00;
        
        double taxaJuros = 1.25/100;
        
        int periodoMes = 6;
        
        double percentualJuros = valorPresente * Math.Pow(1 + taxaJuros, periodoMes);
        
        double f = percentualJuros - valorPresente;

        System.Console.WriteLine($"Valor de início do investimento R$:{valorPresente:C2}");
        System.Console.WriteLine($"Taxa de Juros adicionada ao valor :{taxaJuros*100}%");
        System.Console.WriteLine($"Período mensal :{periodoMes}");
        System.Console.WriteLine($"Rendimento  R$:{f:C2}");
        System.Console.WriteLine($"Valor final de juros R$:{percentualJuros:C2}");
        
        double valorc = valorPresente;
        System.Console.WriteLine("\nRendimento mensal:");
        for (int x = 1; x <= periodoMes; x++) {
            double renda = valorc * taxaJuros;
            valorc += renda;
            System.Console.WriteLine($"\nMês {x}: Rendimento mensal R$ {renda:C2}");
            System.Console.WriteLine($"Valor Final Mensal: R${valorc:C2}");
        }
    }
}