// Задача 37. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первыц и последний элемент, второй и предпоследний  и т.д
// Результат запишите  в новом массиве.
// [1, 2, 3, 4, 5] -> 5 8 3
// [6, 7, 3 ,6] -> 36 21

int[] CreateArrRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.WriteLine(arr[i] + " ]");
    }
}

// int[] CompositionArray(int[] arr)
// {
//     int size1 = 0;
//     if (arr.Length % 2 == 0) size1 = arr.Length / 2;
//     else size1 = arr.Length / 2 + 1;
//     int[] composition = new int[size1];
//     int negindex = arr.Length - 1;
//     for (int i = 0; i < size1; i++)
//     {
//         if (i < negindex)
//         {
//             composition[i] = arr[i] * arr[negindex];
//             negindex--;
//         }
//         else composition[i] = arr[i];
//     }
//     return composition;
// }

int[] CompositionArray(int[] arr)
{
    int size1 = 0;
    if (arr.Length % 2 == 0) size1 = arr.Length / 2;
    else size1 = arr.Length / 2 + 1;
    int[] composition = new int[size1];
    for (int i = 0; i < size1; i++)
    {
        composition[i] = arr[i] * arr[arr.Length-i-1];
    }
    if (arr.Length % 2 != 0) composition[size1-1] = arr[arr.Length/2];
    return composition;
}


int[] array = CreateArrRndInt(9, 1, 10);
PrintArray(array);
int[] result = CompositionArray(array);
PrintArray(result);