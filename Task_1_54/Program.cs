// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortedDescendingItemString(int[,] matrix)
{
    int sizeJ = matrix.GetLength(1);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < sizeJ; j++)
        {
            int temp = 0;
            int size = j;
            if (j < sizeJ)
            {
                while (size < matrix.GetLength(1))
                {
                    if (matrix[i, j] < matrix[i, size])
                    {
                        temp = matrix[i, j];
                        matrix[i, j] = matrix[i, size];
                        matrix[i, size] = temp;
                    }
                    size++;
                }
            }
        }
    }
}

int[,] array2d = CreateMatrixRndInt( 4,4,0,10);
PrintMatrix(array2d);
Console.WriteLine("В итоге получается вот такой массив:");
SortedDescendingItemString(array2d);
PrintMatrix(array2d);