namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao game");
            Console.WriteLine();
            Console.WriteLine("Guerreiro");
            Console.WriteLine("Mago");
            Console.WriteLine("Arqueiro");
            Console.WriteLine();
            Console.Write("Escreva sua classe: ");
            string clase = Console.ReadLine();

            if (clase == "Guerreiro" || clase == "Mago" || clase == "Arqueiro")
            {
                Console.WriteLine("Bem Vindo");
            }
            else
            {
                Console.WriteLine("Erro, tente novamente");
            }
            
        }
    }
}
