// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void PrintTwoMatrix(int[,] matrixA, int[,] matrixB)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4}, ");
            // else Console.Write($"{matrix[i,j], 4}");
            Console.Write(j < matrixA.GetLength(1) - 1 ? $"{matrixA[i, j],4}, " : $"{matrixA[i, j],4}");
        }
        Console.Write("] | [");
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4}, ");
            // else Console.Write($"{matrix[i,j], 4}");
            Console.Write(j < matrixB.GetLength(1) - 1 ? $"{matrixB[i, j],4}, " : $"{matrixB[i, j],4}");
        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}

int[,] ProductMatrixTwo(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            for (int k = 0; k < matrixC.GetLength(0); k++)
            {
                matrixC[i,j] += matrixA[i,k]* matrixB[k,j]; 
            }
        }
    }
    return matrixC;
}

int[,] matrixA = CreateMatrixRndInt(3, 3, 0, 9);
int[,] matrixB = CreateMatrixRndInt(3, 3, 0, 9);
PrintTwoMatrix(matrixA, matrixB);
Console.WriteLine();
PrintMatrix(ProductMatrixTwo(matrixA,matrixB));