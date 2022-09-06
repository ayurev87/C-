// Задача 35. Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат
// в отрезке [10,99].
// Пример для массива из 5, а не 123элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1;
// [1, 2, 3, 6, 2] -> 0;
// [10, 11, 12, 13, 14] -> 5;

int[] CreateArrRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i =0; i < arr.Length; i++)
    {
        arr[i]=rnd.Next(min, max+1);  
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.WriteLine(arr[i]+ " ]");
    }
}

int FindArraySegInt (int[] arr, int min, int max)
{
    int count = 0;
    for(int i=0; i < arr.Length; i++)
    {
        if(min <= arr[i] && max >= arr[i]) count++;
    }
    return count;
}

int[] array = CreateArrRndInt(5, 0, 123);
PrintArray(array);
int result = FindArraySegInt(array, 10, 99);
Console.WriteLine("Значение леажат в отрезке [10;99] - "+ result);