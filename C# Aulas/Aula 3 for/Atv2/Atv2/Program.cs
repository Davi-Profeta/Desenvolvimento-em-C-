namespace Atv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos inimigos irão aparecer: ");
            int enemy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i <= enemy; i++)
            {
                Console.WriteLine("Inimigo " + i + " apareceu");
                Thread.Sleep(500);
            }
        }
    }
}
