using System;

class Program{
    static void Main(string[] args){

        double dias;
        double taxaJuros;
        double Meses; 
        double valorPresente; 
        double vFinal; 
        string continuar;
        int totalDias;
       

        System.Console.WriteLine("Passe o valor inicial: ");
        valorPresente = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Informe a taxa de juros (com vírgula se haver decimais):");
        taxaJuros = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Qual a quantidade de meses: ");
        Meses = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Deseja acrescentar dias?");
        continuar = Convert.ToString(Console.ReadLine());

        if(continuar == "s" || continuar == "sim" || continuar == "S" || continuar == "Sim") {
            System.Console.WriteLine("quantos dias deseja acrescentar?: ");
            dias = Convert.ToInt32(Console.ReadLine());
             DateTime dataAtual = DateTime.Now;
            DateTime dataFutura = dataAtual.AddMonths((int)Meses).AddDays(dias);
            totalDias = (int)(dataFutura - dataAtual).TotalDays;
            vFinal = valorPresente* Math.Pow(1+taxaJuros/100, Meses + dias/30);
        }else {
            vFinal = valorPresente* Math.Pow(1+taxaJuros/100, Meses);
        }
        System.Console.WriteLine($"Valor inicial: R$ {valorPresente:C2}");
        System.Console.WriteLine($"Juros mensal: {taxaJuros}%");
        System.Console.WriteLine($"Período de tempo em meses necessarios: {Meses} ");
        System.Console.WriteLine($"Valor Final: R$ {vFinal:C2}");
    }
}