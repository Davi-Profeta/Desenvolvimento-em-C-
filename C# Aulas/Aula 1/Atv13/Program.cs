namespace Atv13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== Portais ===========");
            Console.WriteLine();
            Console.WriteLine("1 - Gelo");
            Console.WriteLine("2 - Fogo");
            Console.WriteLine("3 - Floresta");
            Console.WriteLine("4 - Deserto");
            Console.WriteLine();
            Console.Write("Qual porta você deseja: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num == 1)
            {
                Console.WriteLine("Está frio aí né");
            }
            else if(num == 2)
            {
                Console.WriteLine("Está quente aqui");
            }
            else if(num == 3)
            {
                Console.WriteLine("Shhi, tem animais perigosos aqui perto");
            }
            else if( num == 4)
            {
                Console.WriteLine("Nuuu, que calor");
            }
            else
            {
                Console.WriteLine("Erro");
            }

        }
    }
}
