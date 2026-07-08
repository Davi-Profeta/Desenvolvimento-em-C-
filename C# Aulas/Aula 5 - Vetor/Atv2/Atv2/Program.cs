namespace Atv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] enemys = new int[8];

            Console.WriteLine("========= Vida dos inimigos ==========");
            Console.WriteLine("São 8 inimigos");
            Console.WriteLine();

            for (int i = 0; i < enemys.Length; i++)
            {
                Console.Write("Armazene a vida do inimigo " + (i + 1) + ": ");
                enemys[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            for (int i = 0; i < enemys.Length; i++)
            {
                if(enemys[i] > 0)
                {
                    Console.WriteLine("O inimigo " + (i+1) + " está vivo");
                }
            }
            
        }
    }
}
