// задача 48: Задайте двумерный массив размера m на n,  каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
//  0 1 2 3 
//  1 2 3 4
//  2 3 4 5

// Console.Write("Вводите число строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Вводите число столбца: ");
// int col = Convert.ToInt32(Console.ReadLine());

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

// int[,] MatrixSum(int row, int col)
int[,] MatrixSum(int[,] matrix)
{
    // int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++) //строка - row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// Стоблцы - col
        {
            matrix[i, j] = i + j;
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
              Console.Write(j < matrix.GetLength(1) - 1? $"{matrix[i,j], 4}, ": $"{matrix[i,j], 4}");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -9, 9);
PrintMatrix(array2D);
Console.WriteLine();
MatrixSum(array2D);
PrintMatrix(array2D);