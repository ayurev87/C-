// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// пример
// 1 4 7 2                         1 4 49 2
// 5 9 2 3                         5 9 2 3
// 8 4 2 4                         64 4 4 4

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
              Console.Write(j < matrix.GetLength(1) - 1? $"{matrix[i,j], 4}, ": $"{matrix[i,j], 4}");
        }
        Console.WriteLine("]");
    }
}
void ChangeEvenIndexToPow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i, j] =matrix[i,j]*matrix[i,j];

        }
    }
}

int[,] array2D = CreateMatrixRndInt(7,7,0,10);
PrintMatrix(array2D);
Console.WriteLine();
ChangeEvenIndexToPow(array2D);
PrintMatrix(array2D);