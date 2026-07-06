namespace Atv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Barra de carregamento");
            Console.WriteLine();

            for(int i = 0; i <= 100; i=i+10)
            {
                Console.WriteLine("Carregando... "+ i +"%");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Carregamento concluido");
        }
    }
}
