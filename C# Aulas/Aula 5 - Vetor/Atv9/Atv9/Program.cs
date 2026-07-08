namespace Atv9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] manaMagos = new int[5];

            int magosManaAlta = 0;
            int magosSemMana = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite a mana do mago {i + 1}: ");
                manaMagos[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (manaMagos[i] > 80)
                {
                    magosManaAlta = magosManaAlta + 1;
                }

                if (manaMagos[i] == 0)
                {
                    magosSemMana = magosSemMana + 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Magos com mana maior que 80: {magosManaAlta}");
            Console.WriteLine($"Magos com mana igual a zero: {magosSemMana}");
        }
    }
}
