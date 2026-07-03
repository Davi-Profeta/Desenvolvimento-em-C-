namespace Atv10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Modo de jogo ======");
            Console.WriteLine();
            Console.WriteLine("1 - Campanha");
            Console.WriteLine("2 - Arena");
            Console.WriteLine("3 - Sobrevivência");
            Console.WriteLine();
            Console.Write("Qual mode você deseja (escolha o número): ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num == 1)
            {
                Console.WriteLine("A história começa com um garoto que morra em um país muito distante em que voê conheça...");
            }
            else if(num == 2)
            {
                Console.WriteLine("Bem vindo a arena de batalha...");
            }
            else if(num == 3)
            {
                Console.WriteLine("Vamos ver se você dá conta de sobreviver...");
            }
            else
            {
                Console.WriteLine("Erro");
            }

        }
    }
}
