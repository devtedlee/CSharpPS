using System;

namespace CSharpProblemSolvingArchive.Etc
{
    public sealed class FindBombGameMaker
    {
        public void PrintBombSquare()
        {
            const int WIDTH = 10;
            const int HEIGHT = 10;
            const int BOMB_COUNT = 10;
            const int BOMB = 9;

            int[,] square = new int[WIDTH, HEIGHT];
            var bombXYs = new (int X, int Y)[BOMB_COUNT];
            var rand = new Random();

            for (int i = 0; i < BOMB_COUNT; ++i)
            {
                int x = rand.Next(0, WIDTH - 1);
                int y = rand.Next(0, HEIGHT - 1);

                if (square[x, y] != 0)
                {
                    --i;
                    continue;
                }

                square[x, y] = BOMB;
                bombXYs[i] = (x, y);
            }

            foreach (var bombXY in bombXYs)
            {
                int xLength = Math.Min(bombXY.X + 2, WIDTH);
                int yLength = Math.Min(bombXY.Y + 2, HEIGHT);

                int x = Math.Max(bombXY.X - 1, 0);
                for (; x < xLength; ++x)
                {
                    int y = Math.Max(bombXY.Y - 1, 0);
                    for (; y < yLength; ++y)
                    {
                        if (square[x, y] != BOMB)
                        {
                            square[x, y] = square[x, y] + 1;
                        }
                    }
                }
            }

            for (int x = 0; x < WIDTH; ++x)
            {
                for (int y = 0; y < HEIGHT; ++y)
                {
                    Console.Write($"{square[x, y]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
