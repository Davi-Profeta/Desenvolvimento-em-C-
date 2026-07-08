namespace Atv6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] missions = new bool[5];
            int completedMissions = 0;

            Console.WriteLine("========== Missoões ===========");

            for(int i = 0; i < missions.Length; i++)
            {
                Console.Write("Você completou a missão " + (i+1) + "(true ou false): ");
                missions[i] = bool.Parse(Console.ReadLine());

                if(missions[i] == true)
                {
                    completedMissions++;
                } 

            }
            Console.WriteLine();
            Console.WriteLine("Foram completadas " + completedMissions + " missões");

        }
    }
}
