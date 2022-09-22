// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int DoNotRepeat(int[,,] matrix, int m, int n, int o)
{
    int a = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == matrix[m, n, o]) 
                {
                    return a= 1;
                    break;
                }
                else if 
                {
                    (matrix[i, j, k] == 0) return a;
                    break;
                }
            }
        }
    }
    return a;
}

int[,,] CreateThreeMatrixRndInt(int row, int col, int zeta, int min, int max)
{
    int[,,] matrix = new int[row, col, zeta];
    Random rnd = new Random();
    bool repeat = true;

    for (int i = 0; i < matrix.GetLength(0); i++) //строка - row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// Стоблцы - col
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                while (repeat == true)
                {
                    matrix[i, j, k] = rnd.Next(min, max + 1);
                    repeat = DoNotRepeat(matrix, i, j, k);
                }
            }
        }

    }
    return matrix;
}

void PrintThreeMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {


                // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4}, ");
                // else Console.Write($"{matrix[i,j], 4}");
                Console.WriteLine(k < matrix.GetLength(2) - 1 ? $"{matrix[i, j, k],3} ({i},{j},{k}) , " : $"{matrix[i, j, k],3} ({i},{j},{k})");
            }
        }
    }

}

int[,,] array3D = CreateThreeMatrixRndInt(2,2,2,0,1);
PrintThreeMatrix(array3D);