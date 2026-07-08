namespace Atv11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] fpsPartidas = new double[10];
            int abaixoDe60 = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o FPS médio da partida {i + 1}: ");
                fpsPartidas[i] = double.Parse(Console.ReadLine());
            }

            double maiorFPS = fpsPartidas[0];
            double menorFPS = fpsPartidas[0];

            for (int i = 0; i < 10; i++)
            {
                if (fpsPartidas[i] > maiorFPS)
                {
                    maiorFPS = fpsPartidas[i];
                }

                if (fpsPartidas[i] < menorFPS)
                {
                    menorFPS = fpsPartidas[i];
                }

                if (fpsPartidas[i] < 60)
                {
                    abaixoDe60++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Maior FPS registrado: {maiorFPS}");
            Console.WriteLine($"Menor FPS registrado: {menorFPS}");
            Console.WriteLine($"Partidas abaixo de 60 FPS: {abaixoDe60}");
        }
    }
}
