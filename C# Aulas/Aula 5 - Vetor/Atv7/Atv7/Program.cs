namespace Atv7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] time = new int[6];

            Console.WriteLine("Tempo de 6 fases");
            Console.WriteLine();

            for (int i = 0; i < time.Length; i++)
            {
                Console.Write("Quanto tempo você demorou na fase " + (i+1) + ": ");
                time[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Esses foram os tempos abaixo de 120 segundos: ");
            for (int i = 0;i < time.Length; i++)
            {
                if(time[i] < 120)
                { 
                    Console.WriteLine("Fase " + (i+1) + ": " + time[i]);
                }
                
            }

        }
    }
}
