// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int row = 6;
int col = 6;
int[,] CreateSpiralMatrix(int row, int col) //Создать Спираль массив
{
    int[,] matrix = new int[row, col];
    int i = 0;
    int j = 0;
    int size = matrix.Length + 1;
    int m = 0;
    int n = 0;
    Console.WriteLine(size);
    for (int k = 1; k < size; k++)
    {
        matrix[i, j] = k;
        if (j < col - 1 && matrix[i, m = j + 1] == 0 && n == 0)
        {
            j++;
        }
        else if (i < row - 1 && matrix[m = i + 1, j] == 0)
        {
            i++;
            n = 1;
        }
        else if (j > 0 && matrix[i, m = j - 1] == 0)
        {
            j--;
        }
        else if (i > 0 && matrix[m = i - 1, j] == 0)
        {
            i--;
        }
        else
        {
            n = 0;
            j++;
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4}, ");
            // else Console.Write($"{matrix[i,j], 4}");
            Console.Write("{0:00}", matrix[i, j]);
            Console.Write("  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array2d = CreateSpiralMatrix(row, col);
PrintMatrix(array2d);