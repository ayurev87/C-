// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateArrReadLine(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите целое число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + " ]");
    }
}

void PosSizeArray(int[] arr)
{
    int pos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) pos++;
    }
    Console.WriteLine($" -> {pos} положительные чисел");
}


int[] array1 = CreateArrReadLine(5);
PrintArray(array1);
PosSizeArray(array1);



