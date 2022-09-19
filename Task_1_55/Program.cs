// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

// void PrintMatrixStringToColumn(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4}, ");
//             // else Console.Write($"{matrix[i,j], 4}");
//             Console.Write(j < matrix.GetLength(1) - 1 ? $"{matrix[j, i],4}, " : $"{matrix[j, i],4}");
//         }
//         Console.WriteLine("]");
//     }
//     Console.WriteLine();
// }


// int [,] NewMatrix(int[,] matrix)
// {
//     int[,] newmatrix = new int [matrix.GetLength(1), matrix.GetLength(0)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             newmatrix[j,i] = matrix[i,j];
//         }
//     }
//     return newmatrix;
// }


// void ChangRowAndCol(int[,] matrix)
// {
//     int replacement = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 1 + i; j < matrix.GetLength(1); j++)
//         {
//             replacement = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = replacement;
//         }
//     }
// }

void ChangRowAndCol(int[,] matrix)
{
    int replacement = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < j)
            {
                replacement = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = replacement;
            }
        }
    }
}

int[,] array2d = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2d);
if (array2d.GetLength(0) == array2d.GetLength(1))
{
    ChangRowAndCol(array2d);
    PrintMatrix(array2d);
}
else Console.WriteLine("Поменять строки с столбцами в этой матрице невозможно");