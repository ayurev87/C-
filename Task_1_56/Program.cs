// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SumItemString(int[,] matrix)
{
    int[] summaString = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summaString[i] += matrix[i,j];
        }
    }
    return summaString;
}

int NumStringMinSummaItems(int[] array)
{
    int min = array[0];
    int indexmin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
            indexmin = i;
        }
    }
    return indexmin+1;
}

int[,] array2D = CreateMatrixRndInt(4,4,0,10);
PrintMatrix(array2D);
Console.WriteLine();
int[] array = SumItemString(array2D);
int result = NumStringMinSummaItems(array);
Console.WriteLine($"Cуммы элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {result} строка");