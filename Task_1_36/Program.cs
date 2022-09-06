// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumArrayOddIndex (int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(4, -99,99);
PrintArray(array);
int result = SumArrayOddIndex(array);
Console.WriteLine($"Сумма: {result} элементов нечетных индексах");