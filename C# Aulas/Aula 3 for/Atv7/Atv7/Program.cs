namespace Atv7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int XP = 0;

            Console.WriteLine("Cada missão concede 150XP");
            Console.Write("Quantas missões você fez: ");
            int missions = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i < missions; i++)
            {
                XP = XP + 150;
                Console.WriteLine("Missão " + i + " | " + XP + " ganho");
                Thread.Sleep(1000);
            }

        }
    }
}
