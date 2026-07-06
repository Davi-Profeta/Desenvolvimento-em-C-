namespace Atv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool podeFazer = true;

            Console.WriteLine("========= Aramadura Lendária ========");
            Console.Write("Quantos ferros você tem: ");
            int irons = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantas madeiras você tem: ");
            int woods = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantos critais você tem: ");
            int crystal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (irons < 80)
            {
                Console.WriteLine("Você não tem ferros suficientes");
                podeFazer = false;
            }

            if(woods < 40)
            {
                Console.WriteLine("Você não tem madeiras o suficiente");
                podeFazer = false;
            }

            if(crystal < 12)
            {
                Console.WriteLine("Você não tem cristais o suficientes");
                podeFazer = false;
            }

            if(podeFazer == true)
            {
                Console.WriteLine("Armadura Lendária feita");
            }

        }
    }
}
