namespace Atv11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos inimigos você derrotou: ");
            int enemies = Convert.ToInt32(Console.ReadLine());

            if( enemies < 10)
            {
                Console.WriteLine("Nenhuma conquista");
            }
            else if( enemies >= 10 && enemies < 49)
            {
                Console.WriteLine("Conquista Caçador");
            }
            else if( enemies >= 50 && enemies < 100)
            {
                Console.WriteLine("Conquista Veterano");
            }
            else
            {
                Console.WriteLine("Conquista lenda");
            }

        }
    }
}
