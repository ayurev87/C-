// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Напримерб в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительных чисел равна 29, сумма
// отрицательных равна -20.

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rdm = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rdm.Next(min, max + 1);
    }
    return arr;
}

// int GetSumPos (int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) sum += arr[i];
//     }
//     return sum;
// }

// int GetSumNeg (int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0) sum += arr[i];
//     }
//     return sum;
// }

int[] GetSumPosNeg (int[] arr)
{
    int Pos = 0;
    int Neg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) Pos += arr[i];
        else Neg += arr[i];
    }
    return new int[]{Pos, Neg};
    // int [] result = new int[2];
    // result[0] = Pos;
    // result[1] = Neg;
    // return result;
}

void Print(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++ )
    {
        if( i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.WriteLine(arr[i] + "]");
    }
}

int[] array = CreateArrayRndInt(12, -9, 9);
// int plus = GetSumPos(array);
// int minus = GetSumNeg(array);
int[] result = GetSumPosNeg(array);
Print(array);
// Console.WriteLine($"Сумма положительных чисел = {plus}, Сумма отрицательных чисел = {minus}");
Console.WriteLine($"Сумма положительных чисел = {result[0]}, Сумма отрицательных чисел = {result[1]}");