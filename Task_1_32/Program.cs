// Задача 32. Напишите программу замена элементов массива: положительные элементы замените на 
// соответствующие отрициательные, и наоборот.
// [-4, -8, 8, 2] -> [ 4, 8, -8, -2]

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

void ChangePosOfNeg (int[] arr)
{
    for(int i = 0; i< arr.Length; i++)
        arr[i] *= -1;
}
int[] array = CreateArrayRndInt(4, -9, 9);
Console.WriteLine("Текующий массив:");
PrintArray(array);
ChangePosOfNeg(array);
Console.WriteLine("Заменяющий массив: положительные элементы на отрициательные и наоборот:");
PrintArray(array);
