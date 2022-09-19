// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //строка - row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// Стоблцы - col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4}, ");
            // else Console.Write($"{matrix[i,j], 4}");
            Console.Write(j < matrix.GetLength(1) - 1 ? $"{matrix[i, j],4}, " : $"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}

void ReplacementString (int[,] matrix)
{
    int replacement =0;
    int size0 = matrix.GetLength(0);
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      replacement = matrix[0,j];
      matrix[0,j] = matrix[size0-1,j];
      matrix[size0-1,j] = replacement;
    }
}

int[,] array2d = CreateMatrixRndInt(4,4, 1, 10);
PrintMatrix(array2d);
ReplacementString(array2d);
PrintMatrix(array2d);