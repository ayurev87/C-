// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

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

Console.Write("Введите количество массив: ");
int size = Convert.ToInt32(Console.ReadLine());

if (size <=0) Console.WriteLine("Некорректное число, а должен быть больше с нуля и целое число!");
else
{
    int[] array1 = CreateArrRndInt(size, -300, 300);
PrintArray(array1);
PosSizeArray(array1);
}


