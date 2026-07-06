namespace Atv5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            Console.WriteLine("Cada moeda vale 5 pontos");
            Console.Write("Quantas moedas você encontrou: ");
            int coins = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= coins; i++)
            {
                soma = soma + i;
            }

            Console.WriteLine("Você conseguiu " + soma + " pontos");
        }
    }
}
