namespace Vetor_aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] players = new int[5];

            for(int i = 0; i < players.Length; i++)
            {
                Console.Write("Qual a pontuação do jogador " + (i + 1) + ": ");
                players[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Essa foram as pontuações: ");
            for(int i = 0;i < players.Length; i++)
            {
                Console.WriteLine(players[i]);
            }
            


        }
    }
}
