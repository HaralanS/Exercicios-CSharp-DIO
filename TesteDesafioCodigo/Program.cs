using System;

class Programa
{
    static void Main(string[] args)
    {
        // Entrada das notas
        string entrada = Console.ReadLine();
        
        // Separar os valores e convertê-los para inteiros
        string[] notasString = entrada.Split(',');
        int produtividade = int.Parse(notasString[0]);
        int qualidade = int.Parse(notasString[1]);
        int pontualidade = int.Parse(notasString[2]);
        
        // TODO: Calcule a média
        double media = (double) (produtividade + qualidade + pontualidade) / 3;
        
        // TODO: Verifique a elegibilidade para bônus
        string elegivelParaBonus = media >= 7 ? "Sim" : "Nao";
        
        // Exibir os resultados
        Console.WriteLine($"Media: {media.ToString("F")}");
        Console.WriteLine($"Elegivel para bonus: {elegivelParaBonus}");
    }
}