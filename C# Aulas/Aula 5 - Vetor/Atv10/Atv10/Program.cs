namespace Atv10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] itensLoja = new string[6];
            bool itemEncontrado = false;

            Console.WriteLine("--- Cadastro de Itens da Loja ---");
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Digite o nome do item {i + 1}: ");
                itensLoja[i] = Console.ReadLine();
            }

            Console.WriteLine("\n--- Busca de Item ---");
            Console.Write("Digite o nome do item que deseja procurar: ");
            string itemProcurado = Console.ReadLine();

            for (int i = 0; i < 6; i++)
            {
                if (itensLoja[i].Equals(itemProcurado, StringComparison.OrdinalIgnoreCase))
                {
                    itemEncontrado = true;
                }
            }

            Console.WriteLine();
            if (itemEncontrado)
            {
                Console.WriteLine($"O item \"{itemProcurado}\" EXISTE na loja!");
            }
            else
            {
                Console.WriteLine($"O item \"{itemProcurado}\" NÃO FOI ENCONTRADO na loja.");
            }

        }
    }
}
