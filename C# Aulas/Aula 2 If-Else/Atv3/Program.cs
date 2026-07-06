namespace Atv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quanto o inimigo está distante de você (em metros): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual a vida do inimigo: ");
            int health = Convert.ToInt32(Console.ReadLine());

            if (health < 30 && m < 15)
            {
                Console.WriteLine("Vida baixa e jogador perto! Recuando!");
            }
            else if (health >= 30 && m < 15)
            {
                Console.WriteLine("Condições favoráveis. Atacar!");
            }
            else
            {
                Console.WriteLine("Jogador fora de alcance. Mantendo patrulha cautelosa.");
            }

        }
    }
}
