using System;

class Program {
    static void Main(string[] args) {

      System.Console.WriteLine("Passe o valor inicial: ");
     double valorPresente = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Informe a taxa de juros (com vírgula se haver decimais):");
        double TaxaJuros = Convert.ToDouble(Console.ReadLine())/100;

        System.Console.WriteLine("Qual o valor Futuro: ");
        double ValorFuturo = Convert.ToDouble(Console.ReadLine());

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
