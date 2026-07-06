namespace Atv10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas tábuas vão ser instaladas: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Tábua " + i + " instalada");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            Console.WriteLine("Ponte concluída");

        }
    }
}
