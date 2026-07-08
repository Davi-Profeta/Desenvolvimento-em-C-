namespace Atv5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de missões diárias realizadas: ");
            int totalMissoes = int.Parse(Console.ReadLine());

            double totalXP = 0.0;
            int contadorBonus = 0;

            for (int i = 1; i <= totalMissoes; i++)
            {
                Console.WriteLine($"\n--- Missão {i} ---");

                Console.Write("Digite o XP obtido: ");
                double xpMissao = double.Parse(Console.ReadLine());

                Console.Write("A missão foi concluída com bônus? (true/false): ");
                bool temBonus = bool.Parse(Console.ReadLine());

                if (temBonus)
                {
                    xpMissao = xpMissao * 2; 
                    contadorBonus++;         
                }

                totalXP = totalXP + xpMissao;
            }

            double mediaXP = 0.0;
            if (totalMissoes > 0)
            {
                mediaXP = totalXP / totalMissoes;
            }

            Console.WriteLine();
            Console.WriteLine($"XP total obtido: {totalXP}");
            Console.WriteLine($"Quantidade de missões com bônus: {contadorBonus}");
            Console.WriteLine($"Média de XP por missão: {mediaXP:F2}"); 
        }
    }
}
