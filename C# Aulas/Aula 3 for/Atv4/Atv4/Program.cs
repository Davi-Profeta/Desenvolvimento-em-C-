namespace Atv4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dano = 0;

            Console.WriteLine("Cada golpe você dá 15 de dano");
            Console.Write("Quantos golpes você deu: ");
            int golpes = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= golpes; i++)
            {
                Console.WriteLine("Combo " + i + "X" + (dano=dano+15));
                Thread.Sleep(500);
            }

        }
    }
}
