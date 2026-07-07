namespace Atv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double desconto = 0;
            double price = 0;
            double total = 0;

            Console.WriteLine("==== Loja do ferreiro ======");
            Console.WriteLine();
            Console.Write("Quantos itens você deseja comprar: ");
            int itens = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= itens; i++)
            {
                Console.Write("Qual o nome do equipamento " + i +": ");
                string name = Console.ReadLine();
                Console.WriteLine();
            }

            for (int i = 1 ;i <= itens; i++)
            {
                Console.Write("Qual o valor do item " + i + ": ");
                price = Convert.ToDouble(Console.ReadLine());
                total = total + price;
                Console.WriteLine();
            }


            if (total >= 500)
            {
                Console.WriteLine("Você recebeu um desconto de 10%");
                Console.WriteLine();
                desconto = total * 0.10;
            }

            Console.WriteLine("Valor total: " + total);

            if(total >= 500)
            {
                Console.WriteLine("Valor economizado: " + desconto);
                Console.WriteLine("Valor com desconto: " + (total - desconto));
            }

            


        }
    }
}
