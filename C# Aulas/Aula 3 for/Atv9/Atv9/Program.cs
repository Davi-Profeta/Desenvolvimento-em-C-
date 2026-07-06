namespace Atv9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            Console.Write("Quantos inimigos você atingiu: ");
            int enemy = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= enemy; i++)
            {
                Console.Write("Quanto de dano você deu no inimigo " + i + ":");
                int dano = Convert.ToInt32(Console.ReadLine());
                soma = soma + dano;
            }
            Console.WriteLine("Você causou " + soma + " de dano");

        }
    }
}
