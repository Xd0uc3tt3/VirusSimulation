using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusSimulation
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
        }

        static void PrintMap()
        {
            char[,] map = new char[,]
            {
                {'-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-'},
                {'-', '^', '-', '^', '-', '-', '-', '-', '-', '^', '-', '^', '-'},
                {'^', '^', '^', '^', '^', '-', '-', '-', '^', '^', '^', '^', '^'},
                {'-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-'},
                {'~', '~', '~', '~', '-', '-', '-', '-', '-', '-', '-', '-', '-'},
                {'~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~'},
                {'~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~'},
                {'~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~', '~'}
            };

            int rows = map.GetLength(0);
            int cols = map.GetLength(1);

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    Console.Write(map[y, x]);
                }
                Console.WriteLine();
            }

        }

        static void DrawVirus()
        {
            List<(int x, int y)> viruses = new List<(int x, int y)>
            {
                (0, 0),
                (2, 3),
                (5, 4)
            };

            Random rand = new Random();

            while (true)
            {
                Console.Clear();
                DrawMapWithViruses(viruses);
                Thread.Sleep(1000);

                List<(int x, int y)> newViruses = new List<(int x, int y)>();

                for (int i = 0; i < viruses.Count; i++)
                {
                    (int oldX, int oldY) = viruses[i];
                    (int newX, int newY) = MoveVirus(oldX, oldY, rand);

                    if (rand.Next(0, 100) < 10)
                        newViruses.Add((oldX, oldY));

                    viruses[i] = (newX, newY);
                }

                viruses.AddRange(newViruses);
            }

        }
    }
}
