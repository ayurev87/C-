// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++ )
    {
        if( i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.WriteLine(arr[i] + "]");
    }
}

int CountPosArray (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if( array[i]%2 ==0) count++;
    }
    return count;
}

int[] array = CreateArrayRndInt(4, 100, 999);
PrintArray(array);
int result = CountPosArray(array);
Console.WriteLine(result + " - количества чётных чисел в массиве.");