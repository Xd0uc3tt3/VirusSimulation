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
            PrintMap();

            Console.ReadKey();

            DrawVirus();
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
            List<(int, int)> virus = new List<(int x, int y)>();

            


        }
    }
}
