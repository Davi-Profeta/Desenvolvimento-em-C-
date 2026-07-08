namespace Atv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vetorPersoagem = new string[6];

            Console.WriteLine("=============== RPG =============");
            Console.WriteLine("Você pode cadastrar 6 personagens");

            for(int i = 0; i < vetorPersoagem.Length; i++)
            {
                Console.Write("Qual o nome do personagem " + (i + 1) + ": ");
                vetorPersoagem[i] = Console.ReadLine();
            }
            Console.WriteLine("");
            for (int i = 0; i < vetorPersoagem.Length; i++)
            {
                Console.WriteLine("Personagem " + (i+1) + ": " + vetorPersoagem[i]);
            }
        }
    }
}
