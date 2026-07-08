namespace Atv12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] slotsServidor = new bool[12];

            int jogadoresOnline = 0;
            int jogadoresOffline = 0;

            Console.WriteLine("--- Status dos Slots do Servidor ---");
            for (int i = 0; i < 12; i++)
            {
                Console.Write($"O slot {i + 1} está ocupado/online? (true/false): ");
                slotsServidor[i] = bool.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 12; i++)
            {
                if (slotsServidor[i] == true)
                {
                    jogadoresOnline = jogadoresOnline + 1;
                }
                else
                {
                    jogadoresOffline = jogadoresOffline + 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Jogadores Online: {jogadoresOnline}");
            Console.WriteLine($"Slots Vazios / Offline: {jogadoresOffline}");
        }
    }
}
