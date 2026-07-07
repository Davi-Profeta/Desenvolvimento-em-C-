namespace Atv4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int success = 0;
            int committed = 0;

            Console.WriteLine("=========== Torre de defesa =============");
            Console.WriteLine();
            Console.Write("Quantas ondas de inimigos vai ter: ");
            int waves = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= waves; i++)
            {
                Console.Write("Quantos inimigos foram derrotados na onda " + i + ": ");
                int enemys = Convert.ToInt32(Console.ReadLine());

                if(enemys >= 5)
                {
                    Console.WriteLine("Onda defendida com sucesso");
                    Console.WriteLine();
                    success++;
                }
                else
                {
                    Console.WriteLine("Defesa comprometida!");
                    Console.WriteLine();
                    committed++;
                }

                total = enemys + total;
            }
            Console.WriteLine();
            Console.WriteLine("Foram derrotados " + total + " inimigos");
            Console.WriteLine("Quantidades de ondas defendidas: " + success);
            Console.WriteLine("Quantidade de ondas comprometidas: " + committed);

        }
    }
}
