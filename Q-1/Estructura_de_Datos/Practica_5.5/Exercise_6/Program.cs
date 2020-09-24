using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            static int[,] GenerateGrid()
            {
                int[] gridLengths = new int[2];
                int rows = 0;
                int columns = 0;

                bool isNum = false;

                while (!isNum)
                {
                    Console.WriteLine("Ingrese la cantidad de filas de la grilla: ");

                    isNum = int.TryParse(Console.ReadLine(), out rows);

                    if (rows > 20)
                    {
                        Console.WriteLine("El tamaño maximo de la grilla es 20x20.");
                        isNum = false;
                    }
                }
                isNum = false;

                while (!isNum)
                {
                    Console.WriteLine("Ingrese la cantidad de columnas de la grilla: ");

                    isNum = int.TryParse(Console.ReadLine(), out columns);

                    if (columns > 20)
                    {
                        Console.WriteLine("El tamaño maximo de la grilla es 20x20.");
                        isNum = false;
                    }
                }

                gridLengths[0] = rows;
                gridLengths[1] = columns;

                int[,] grid = new int[gridLengths[0], gridLengths[1]];

                return grid;
            }

            static int GetNumAliveCells(int[,] grid)
            {
                int cells = 0;
                int maxCells = grid.GetLength(0) * grid.GetLength(1);
                bool isNum = false;

                while (!isNum)
                {
                    Console.WriteLine("Indique la cantidad de celulas vivas para la grilla:");

                    isNum = int.TryParse(Console.ReadLine(), out cells);

                    if (cells > maxCells)
                    {
                        Console.WriteLine($"No hay esa cantidad de celulas en la grilla, ingrese por favor un numero menor o igual a: {maxCells}");
                        isNum = false;
                    }
                }

                return cells;
            }

            static int[,] PlaceAliveCells(int[,] grid, int aliveCells)
            {
                int row;
                int column;

                for (int i = 1; i <= aliveCells; i++)
                {
                    Console.WriteLine($"Indique donde quiere colocar la celula viva numero {i}");

                    Console.Write("Fila: ");
                    row = int.Parse(Console.ReadLine());

                    Console.Write("Columna: ");
                    column = int.Parse(Console.ReadLine());


                    grid[row, column] = 1;
                    for (int j = 0; j < grid.GetLength(0); j++)
                    {
                        for (int k = 0; k < grid.GetLength(1); k++)
                        {
                            Console.Write($"{grid[j, k]} ");
                        }
                        Console.WriteLine();
                    }
                }

                return grid;
            }

            static void PlayGame(int[,] grid)
            {
                Console.WriteLine("Presione enter para empezar la simulación:");
                Console.ReadLine();

                int aliveCells = 0;
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    for (int j = 0; j < grid.GetLength(1); j++)
                    {
                        if (grid[i, j] == 1)
                        {
                            aliveCells++;
                        }
                    }
                }

                while (aliveCells > 0)
                {
                    int surroundingCells = 0;
                    for (int i = 0; i < grid.GetLength(0); i++)
                    {
                        for (int j = 0; j < grid.GetLength(1); j++)
                        {
                            if (i == 0 && j == 0)
                            {
                                if (grid[i, j + 1] == 0)
                                {
                                    surroundingCells++;
                                }
                                if (grid[i + 1, j] == 0)
                                {
                                    surroundingCells++;
                                }
                                if (grid[i + 1, j + 1] == 0)
                                {
                                    surroundingCells++;
                                }
                            }

                            if (i == grid.GetLength(0) - 1 && j == grid.GetLength(1) - 1)
                            {
                                if (grid[i, j - 1] == 0)
                                {
                                    surroundingCells++;
                                }
                                if (grid[i, j] == 0)
                                {
                                    surroundingCells++;
                                }

                                if (grid[i - 1, j] == 0)
                                {
                                    surroundingCells++;
                                }
                            }

                            if (grid[i - 1, j - 1] == 0)
                            {
                                surroundingCells++;
                            }
                            if (grid[i - 1, j] == 0)
                            {
                                surroundingCells++;
                            }
                            if (grid[i - 1, j + 1] == 0)
                            {
                                surroundingCells++;
                            }

                            if (grid[i, j - 1] == 0)
                            {
                                surroundingCells++;
                            }
                            if (grid[i, j] == 0)
                            {
                                surroundingCells++;
                            }
                            if (grid[i, j + 1] == 0)
                            {
                                surroundingCells++;
                            }

                            if (grid[i + 1, j - 1] == 0)
                            {
                                surroundingCells++;
                            }
                            if (grid[i + 1, j] == 0)
                            {
                                surroundingCells++;
                            }
                            if (grid[i + 1, j + 1] == 0)
                            {
                                surroundingCells++;
                            }

                            if (grid[i, j] == 0 && surroundingCells > 3)
                            {
                                grid[i, j] = 1;
                            }

                            if (grid[i, j] == 1 && surroundingCells < 2)
                            {
                                grid[i, j] = 0;
                            }
                        }
                    }

                    for (int i = 0; i < grid.GetLength(0); i++)
                    {
                        for (int j = 0; j < grid.GetLength(1); j++)
                        {
                            if (grid[i, j] == 1)
                            {
                                aliveCells++;
                            }
                        }
                    }

                    Console.WriteLine("Presione enter para avanzar al siguiente turno");
                    Console.ReadLine();
                }

            }

            int[,] grilla = GenerateGrid();
            int celulasVivas = GetNumAliveCells(grilla);

            grilla = PlaceAliveCells(grilla, celulasVivas);

            PlayGame(grilla);
        }
    }
}
