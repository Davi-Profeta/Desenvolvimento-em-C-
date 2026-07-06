namespace Atv11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int win = 0;
            int loser = 0;

            Console.Write("Quantas partidas você jogou: ");
            int games = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < games; i++)
            {
                Console.WriteLine("Digite de acordo com sua colocação");
                Console.WriteLine("1- Vitória");
                Console.WriteLine("2 - Derrota");
                Console.Write("Digite o número: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if(num == 1)
                {
                    win++;
                }
                else if(num == 2)
                {
                    loser++;
                }
                else
                {
                    Console.WriteLine("Erro");
                }
                Console.WriteLine();

            }
            Console.WriteLine("Você teve " + win + " vitórias");
            Console.WriteLine("Você teve " + loser + " derrotas");

        }
    }
}
