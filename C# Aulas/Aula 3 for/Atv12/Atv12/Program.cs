namespace Atv12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            Console.Write("Quantos dias você ficou coletando ouro: ");
            int days = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < days; i++)
            {
                Console.Write("No dia " + i + " você coletou quanto de ouro: ");
                int gold = Convert.ToInt32(Console.ReadLine());

                soma = soma + gold;
            }
            Console.WriteLine();
            Console.WriteLine("Você tem "+soma+" de ouro");
            Console.WriteLine("Sua média foi de " + (soma / days) + " ouros por dia");

        }
    }
}
