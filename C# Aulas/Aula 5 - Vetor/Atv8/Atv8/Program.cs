namespace Atv8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] coins = new int[8];
            int totalCoins = 0;
            int biggerCoins = 0;
            int fase = 0;

            Console.WriteLine("O jogo possui 8 fases");

            for (int i = 0; i < coins.Length; i++)
            {
                Console.Write("Qunatas moedas você coletou na fase " + (i+1) + ": ");
                coins[i] = Convert.ToInt32(Console.ReadLine());

                if(coins[i] > biggerCoins)
                {
                    biggerCoins = coins[i];
                    fase = i + 1;
                }

                totalCoins = totalCoins + coins[i];
            }
            Console.WriteLine();
            Console.WriteLine("Foram coletadas " + totalCoins + " moedas");
            Console.WriteLine("A fase " + fase + " teve mais moedas, foram " + biggerCoins + " moedas coletadas");

        }
    }
}
