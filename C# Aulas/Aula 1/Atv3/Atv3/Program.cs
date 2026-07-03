namespace Atv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a loja");
            Console.WriteLine();
            Console.WriteLine("Itens disponíveis");
            Console.WriteLine("Espada = 100 moedas");
            Console.WriteLine("Arco = 150 moedas");
            Console.WriteLine("Cajado = 200 moedas");

            Console.WriteLine();

            Console.Write("Quantas moedas você tem: ");
            int moedas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual item você deseja: ");
            string item = Console.ReadLine();

            if (item == "Espada" || item == "Arco" || item == "Cajado")
            {
                if (item == "Espada" && moedas >= 100 ||
                   item == "Arco" && moedas >= 150 ||
                   item == "Cajado" && moedas >= 200)
                {
                    Console.WriteLine("Compra realizada");
                }
                else
                {
                    Console.WriteLine("Moedas insuficientes");
                }
                
            }
            else
            {

                Console.WriteLine("Esse item não existe");

            }

           

        }
    }
}
