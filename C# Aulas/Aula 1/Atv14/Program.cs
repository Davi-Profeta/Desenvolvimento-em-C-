namespace Atv14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você precisa de 150 critais para passar de missão");
            Console.Write("Quantos cristais você: ");
            int crytals = Convert.ToInt32(Console.ReadLine());

            if(crytals < 150)
            {
                Console.WriteLine("Você precisa de mais "+(150 - crytals));
            }
            else if(crytals == 150)
            {
                Console.WriteLine("Você passou");
            }
            else if( crytals > 150)
            {
                Console.WriteLine("Você passou de fase");
                Console.WriteLine("Sobraram "+ (crytals - 150));
            }

        }
    }
}
