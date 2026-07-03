namespace Atv4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Você possui a DLC (sim ou não): ");
            String DLC = Console.ReadLine();

            if (DLC == "sim" || DLC == "Sim" || DLC == "SIM")
            {
                Console.WriteLine("Novo mapa desbloqueado");
            }
            else if(DLC == "NÃO" || DLC == "Não" || DLC == "não")
            {
                Console.WriteLine("Compre a DLC para acessar o novo mapa");
            }
            else
            {
                Console.WriteLine("Erro");
            }

        }
    }
}
