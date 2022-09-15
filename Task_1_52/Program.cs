// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] MeanArithmeticArray (int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result[i] += matrix[j, i];
        }
        result[i]/=matrix.GetLength(0);
    } 
    return result;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++ )
    {
        if( i < array.Length - 1) 
        {
            Console.Write("{0:0.0}" ,array[i]);
            Console.Write(", ");
        }
        else 
        {
            Console.Write("{0:0.0}" ,array[i]);
            Console.WriteLine(" ]");
        }
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
double[] result = MeanArithmeticArray(array2D);
Console.Write("Найдите среднее арифиметические массивы: ");
PrintArray(result);