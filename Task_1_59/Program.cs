// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
//  на пересечении которых расположен наименьший элемент массива.
//   например, задан массив:
//   1 4 7 2
//   5 9 2 3
//   8 4 2 4 
//   5 2 6 7

//   Наименьший элемент - 1, на выходе получим следующий массив:
//   9 2 3
//   4 2 4 
//   2 6 7

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

// bool FindIntersection(int i, int j, int index, int count, int[] DelRow, int[] DelCol)
// {
//     bool result = false;
//     if (index == count) return true;
//     if (i != DelRow[index] && j != DelCol[index])
//     {
//         index++;
//         result = FindIntersection(i, j, index, count, DelRow, DelCol);
//     }
//     return result;
// }
bool FindIntersection(int i, int index, int count, int[] Del)
{
    bool result = false;
    if (index == count) return true;
    if (i != Del[index])
    {
        index++;
        result = FindIntersection(i,index, count, Del);
    }
    return result;
}

int[,] DeleteRowAndColOfMinValue(int[,] matrix)
{
    int min = matrix[0, 0];

    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++) //найдет наименьше элемент
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
            }
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++) // найдет количество наименьше элементо.
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min == matrix[i, j])
            {
                count++;
            }
        }
    }
    int[] DelRow = new int[count]; //установить количество наименьше элементы на массиве.
    int[] DelCol = new int[count];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) //найдет пересечение элементы.
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min == matrix[i, j])
            {
                DelRow[index] = i;
                DelCol[index] = j;
                index++;
            }
        }

    }
    int countRow = 0;
    int countCol = 0;
    for (int i = 0; i < DelRow.Length; i++) //найти количество убрать строки и столбец
    {
        for (int j = i + 1; j < DelRow.Length; j++)
        {
            if (DelRow[i] == DelRow[j]) countRow++;
            if (DelCol[i] == DelCol[j]) countCol++;
        }
    }
    countRow = DelRow.Length - countRow; // остаток количество строки и столбец
    countCol = DelCol.Length - countCol;
    int[,] result = new int[matrix.GetLength(0) - countRow, matrix.GetLength(1) - countCol];
    int k = 0;
    int m = 0;
    index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (FindIntersection(i, index, DelRow.Length, DelRow))
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (FindIntersection(j, index, DelCol.Length, DelCol))
                {
                    result[k, m] = matrix[i, j];
                    m++;
                }

                // if (i < minRow && j < minCol) result[i, j] = matrix[i, j];
                // else if (i >= minRow && j >= minCol) result[i, j] = matrix[i + 1, j + 1];
                // else if (i < minRow && j >= minCol) result[i, j] = matrix[i, j + 1];
                // else if (i >= minRow && j < minCol) result[i, j] = matrix[i + 1, j];
            }
            k++;
            m = 0;
        }
    }
    return result;
}

int[,] array2D = CreateMatrixRndInt(5, 6, 1, 10);
PrintMatrix(array2D);
int[,] result1 = DeleteRowAndColOfMinValue(array2D);
PrintMatrix(result1);