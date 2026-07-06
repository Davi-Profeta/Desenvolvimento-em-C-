namespace Atv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contagem regressiva");
            Console.WriteLine();

            for(int i = 5; i > 0; i--)
            {
                Console.WriteLine("Lançamento em " + i);
                Thread.Sleep(500);
            }

            Console.WriteLine();
            Console.WriteLine("Foguete lançado!");

        }
    }
}
