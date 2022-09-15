// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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
}

void PosistionMatrix(int[,] matrix, int row, int col)
{
    int rowsize = matrix.GetLength(0)+1;
    int colsize = matrix.GetLength(1)+1;
    Console.WriteLine(rowsize + ", " + colsize);
    if (row < rowsize && col < colsize)
    {
        Console.WriteLine($"{row}, {col} -> {matrix[row - 1, col - 1]}");
    }
    else Console.WriteLine($"{row}, {col} -> такого элемента в массиве нет");
}

Console.Write("Вводите элемента строка: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вводите элемента столбец: ");
int col1 = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
PosistionMatrix(array2D, row1, col1);