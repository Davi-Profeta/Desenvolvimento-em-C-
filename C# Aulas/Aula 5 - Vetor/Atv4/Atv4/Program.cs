using System.Security.Principal;

namespace Atv4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetorPocoes = new int[10];
            int total = 0;
            int espacoVazio = 0;

            Console.WriteLine("======== Inventário de poções ================");
            Console.WriteLine();

            for (int i = 0; i < vetorPocoes.Length; i++)
            {
                Console.Write("Quantas poções você tem no espaço " + (i+1) + ": ");
                vetorPocoes[i] = Convert.ToInt32(Console.ReadLine());

                if (vetorPocoes[i] <= 0)
                {
                    espacoVazio++;
                }

                total = total + vetorPocoes[i];
            }
            Console.WriteLine();
            Console.WriteLine("Foram armazenados " + total + " poções");
            Console.WriteLine("Ficaram " + espacoVazio + " espaços vazios");


        }
    }
}
