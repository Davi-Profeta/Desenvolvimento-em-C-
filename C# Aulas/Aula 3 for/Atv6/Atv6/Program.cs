namespace Atv6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos pontos de patrulha o NPC vai percorrer: ");
            int npc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i <= npc; i++)
            {
                Console.WriteLine("Visitando ponto " + i);
                Thread.Sleep(2000);
            }
            Console.WriteLine("Patrulha concluída");
        }
    }
}
