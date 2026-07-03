namespace Atv_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a energia atual do seu personagem: ");
            int energy = Convert.ToInt32(Console.ReadLine());

            if(energy >= 70)
            {
                Console.WriteLine("Pode usar qualquer habilidade");
            }
            else if(energy < 70 && energy >= 30)
            {
                Console.WriteLine("Apenas habilidades médias");
            }
            else if(energy < 30 && energy >= 1)
            {
                Console.WriteLine("Apenas habilidades básicas");
            }
            else if(energy == 0)
            {
                Console.WriteLine("Personagem exausto");
            }
            else
            {
                Console.WriteLine("Erro");
            }

        }
    }
}
