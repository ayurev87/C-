// Задача 57. Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Набор данных                |   Частотный массив
// {1, 9, 9, 0, 2, 8, 0, 9}    |  0 встречается 2 раза
//                             | 1 встречается 1 раз
//                             | 2 встречается 1 раз
//                             | 8 встречается 1 раз
//                             | 9 встречается 3 раза
// -------------------------------------------------------
// 1,2,3                       | 1 встречается 3 раза
// 4,6,1                       | 2 встречается 2 раз
// 2,1,6                       | 3 встречается 1 раз
//                             | 4 встречается 1 раз
//                             | 6 встречается 2 раза

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

void distionary(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k =0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i,j];
            k++;
        }
    }
    Array.Sort(array);
    int count = 1;
    int value = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(value != array[i])
        {
            Console.Write($"Значение {value} встречается {count} ");
            Console.WriteLine(count > 2 && count < 5? "раза": "раз");
            value=array[i];
            count=1;
        }        
        else count++;
    }
    Console.Write($"Значение {value} встречается {count} ");
    Console.WriteLine(count > 2 && count < 5? "раза": "раз");
}

int[,] array2D = CreateMatrixRndInt(4,4,0,10);
PrintMatrix(array2D);
distionary(array2D);
