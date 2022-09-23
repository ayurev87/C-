// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
bool DoNotRepeat(int[,,] matrix, int m, int n, int o)
{
    bool a = true;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if(i == m && j == n && k == o) return a =false;
                else if (matrix[i, j, k] == matrix[m, n, o]) 
                {
                    return a;
                }
            }
        }
    }
    a= false;
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
                repeat = true;
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
                Console.WriteLine($"{matrix[i, j, k],3} ({i},{j},{k})");
            }
        }
    }

}

int[,,] array3D = CreateThreeMatrixRndInt(2,2,2,10,99);
PrintThreeMatrix(array3D);