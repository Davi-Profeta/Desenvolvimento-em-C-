namespace Atv_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual servidor você é: ");
            Console.WriteLine();
            Console.WriteLine("1 - América");
            Console.WriteLine("2 - Europa");
            Console.WriteLine("3 - Ásia");
            Console.WriteLine();
            Console.Write("Digite o número do servidor: ");
            int server = Convert.ToInt32(Console.ReadLine());

            if(server == 1)
            {
                Console.WriteLine("!Dalle Paraguay!");
            }
            else if(server == 2)
            {
                Console.WriteLine("Champions League");
            }
            else if(server == 3)
            {
                Console.WriteLine("Ni hau");
            }
            else
            {
                Console.WriteLine("Servirdor não exite");
            }


        }
    }
}
