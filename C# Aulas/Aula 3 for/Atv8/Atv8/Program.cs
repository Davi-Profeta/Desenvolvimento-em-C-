namespace Atv8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int num;

            Console.Write("Quantos baús foram abertos: ");
            int chests = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= chests; i++)
            {
                Console.Write("Quantas moedas você pegou no baú "+i+": ");
                num = Convert.ToInt32(Console.ReadLine());
                soma = num + soma;
                
            }
            Console.WriteLine("Você tem " + soma + " moedas");

        }
    }
}
