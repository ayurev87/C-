// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("введите числа массива: ");
int i = Convert.ToInt32(Console.ReadLine());

int[] NewArray(int index)
{
    int[] arr = new int[index];
    for ( int i = 0; i < arr.Length; i++)
    {
        Random rmd = new Random();
        arr[i] = rmd.Next(0,100);
    } 
    return arr;
 }

 void PrintArray(int []arr)
 {
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length-1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
 }
 if ( i > 8) Console.WriteLine("Введены Некорректный массив, а требует максимальные 8 массива");
 if (i < 1) Console.WriteLine("Введены некорректное число нижеб чем нуля , а требует положительное число");
 else 
 {
    int[] array = NewArray(i);
    PrintArray(array);
 }