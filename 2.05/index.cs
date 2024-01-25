using System;

class Program {
    static void Main(string[] args) {

        double valorPresente = 3800.00;
        double TaxaJuros = 1.25 / 100;
        double ValorFuturo = 7390.61;

        double Valorrequerido = (ValorFuturo - valorPresente);

        double x = Math.Log(ValorFuturo / valorPresente) / Math.Log(1 + TaxaJuros);
        int Meses = (int)Math.Ceiling(x);

        System.Console.WriteLine($"Valor inicial: R$ {valorPresente:C2}");
        System.Console.WriteLine($"Juros mensal: {TaxaJuros * 100}%");
        System.Console.WriteLine($"Valor futuro: R$ {ValorFuturo:C2}");
        System.Console.WriteLine($"Período de tempo em meses necessarios: {Meses}");
        System.Console.WriteLine($"Valor necessário para atingir o valor: R$ {Valorrequerido:C2}");
    }
}