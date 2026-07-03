namespace Atv5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int respawn = 10;

            if(respawn > 0)
            {
                Console.WriteLine("Faltam " + respawn + " segundo para o respawn");
            }
            else if(respawn == 0)
            {
                Console.WriteLine("Jogador resnaceu");
            }
            else
            {
                Console.WriteLine("Erro");
            }
        }
    }
}
