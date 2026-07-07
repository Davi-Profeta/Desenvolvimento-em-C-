namespace Atv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double better = 0;
            double worse = double.MaxValue;
            double total = 0;

            Console.Write("Quantas partidas você jogou: ");
            int matches = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= matches; i++)
            {
                Console.Write("Quanto tempo(em segundos) você demorou na partida " + i + ": ");
                int seconds = Convert.ToInt32(Console.ReadLine());
                total = total + seconds;

                if (seconds > better)
                {
                    better = seconds;
                }

                if (seconds < worse)
                {
                    worse = seconds;
                }
            }

            double media = total / matches;

            Console.WriteLine();
            Console.WriteLine($"Seu melhor tempo foi de {(worse / 60):F2} minutos");
            Console.WriteLine("==========");
            Console.WriteLine($"Seu pior tempo foi de {(better / 60):F2} minutos");
            Console.WriteLine("==========");
            Console.WriteLine($"Sua média foi de {(media / 60):F2} minutos");

        }
    }
}
