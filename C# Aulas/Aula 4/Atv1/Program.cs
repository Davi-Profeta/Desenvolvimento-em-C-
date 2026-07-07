namespace Atv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dano = 0;
            Console.WriteLine("============= Arena de sobrevivência =================");
            Console.WriteLine();
            Console.Write("Quantos inimigos você derrotou: ");
            int enemy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quanto você tem de vida: ");
            int health = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= enemy; i++)
            {
                Console.WriteLine("Inimigo " + i + " - Você recebeu quanto de dano:");
                dano = Convert.ToInt32(Console.ReadLine());
                health = health - dano;
                if(health <= 0)
                {
                    Console.WriteLine("GAME OVER");
                    break;
                }

                Console.WriteLine("Você ficou com " + health + " de vida");
                Console.WriteLine();


            }
            Console.WriteLine();
            if(health > 0)
            {
                Console.WriteLine("Parabéns, você sobreviveu a arena");
            }
            

        }
    }
}
