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
                int gridRows = grid.GetLength(0);
                int gridColumns = grid.GetLength(1);

                int row = 0;
                int column = 0;

                for (int i = 1; i <= aliveCells; i++)
                {
                    bool inRangeRow = false;
                    bool inRangeColumn = false;

                    Console.WriteLine($"Indique donde quiere colocar la celula viva numero {i}");

                    while (!inRangeRow)
                    {
                        Console.Write("Fila: ");
                        inRangeRow = int.TryParse(Console.ReadLine(), out row);

                        if (row > gridRows)
                        {
                            Console.WriteLine($"El numero ingresado es mayor a la cantidad de filas de la grilla: {gridRows}");
                            Console.WriteLine("Por favor ingrese otro:");
                            inRangeRow = false;
                        }
                    }

                    while (!inRangeColumn)
                    {
                        Console.Write("Columna: ");
                        inRangeColumn = int.TryParse(Console.ReadLine(), out column);

                        if (column > gridColumns)
                        {
                            Console.WriteLine($"El numero ingresado es mayor a la cantidad de columnas de la grilla: {gridColumns}");
                            Console.WriteLine("Por favor ingrese otro:");
                            inRangeColumn = false;
                        }
                    }

                    grid[row - 1, column - 1] = 1;

                    for (int j = 0; j < gridRows; j++)
                    {
                        for (int k = 0; k < gridColumns; k++)
                        {
                            Console.Write($"{grid[j, k]} ");
                        }
                        Console.WriteLine();
                    }
                }

                return grid;
            }

            static void PlayGame(int[,] grid, int aliveCells)
            {
                Console.WriteLine("Presione enter para empezar la simulación:");
                Console.ReadLine();

                int gridRows = grid.GetLength(0);
                int gridColumns = grid.GetLength(1);

                while (aliveCells > 0)
                {
                    for (int i = 0; i < gridRows; i++)
                    {
                        for (int j = 0; j < gridColumns; j++)
                        {
                            int surroundingAliveCells = 0;

                            // Superior izquierda
                            if (i > 0 && j > 0 && grid[i - 1, j - 1] == 1)
                            {
                                surroundingAliveCells++;
                            }

                            // Superior
                            if (i > 0 && grid[i - 1, j] == 1)
                            {
                                surroundingAliveCells++;
                            }

                            // Superior derecha
                            if (i > 0 && j < gridColumns - 1 && grid[i - 1, j + 1] == 1)
                            {
                                surroundingAliveCells++;
                            }


                            // Izquierda
                            if (j > 0 && grid[i, j - 1] == 1)
                            {
                                surroundingAliveCells++;
                            }

                            // Derecha
                            if (j < gridColumns - 1 && grid[i, j + 1] == 1)
                            {
                                surroundingAliveCells++;
                            }

                            // Inferior izquierda
                            if (i < gridRows - 1 && j > 0 && grid[i + 1, j - 1] == 1)
                            {
                                surroundingAliveCells++;
                            }

                            // Inferior
                            if (i < gridRows - 1 && grid[i + 1, j] == 1)
                            {
                                surroundingAliveCells++;
                            }

                            // Inferior derecha
                            if (i < gridRows - 1 && j < gridColumns - 1 && grid[i + 1, j + 1] == 1)
                            {
                                surroundingAliveCells++;
                            }

                            // Si está muerta y la rodean exactamente 3 celulas vivas, "nace"
                            if (grid[i, j] == 0 && surroundingAliveCells == 3)
                            {
                                grid[i, j] = 1;
                            }

                            // Si está viva y la rodean menos de 2 o mas de 3 celulas vivas, muere
                            if (grid[i, j] == 1 && surroundingAliveCells < 2 || surroundingAliveCells > 3)
                            {
                                grid[i, j] = 0;
                            }
                        }
                    }

                    // Actualizamos la cantidad de celulas vivas y mostramos la grilla
                    aliveCells = 0;
                    for (int j = 0; j < gridRows; j++)
                    {
                        for (int k = 0; k < gridColumns; k++)
                        {
                            Console.Write($"{grid[j, k]} ");

                            if (grid[j, k] == 1)
                            {
                                aliveCells++;
                            }
                        }
                        Console.WriteLine();
                    }

                    if (aliveCells > 0)
                    {
                        Console.WriteLine("Presione enter para avanzar al siguiente turno");
                    }
                    else
                    {
                        Console.WriteLine("Todas las celulas han muerto");
                    }

                    Console.ReadLine();
                }
            }

            Console.WriteLine("===== Conway's Game of Life =====");

            int[,] grilla = GenerateGrid();
            int celulasVivas = GetNumAliveCells(grilla);

            Console.WriteLine("Celulas vivas -> 1");
            Console.WriteLine("Celulas muertas -> 0");

            grilla = PlaceAliveCells(grilla, celulasVivas);

            PlayGame(grilla, celulasVivas);
        }
    }
}
