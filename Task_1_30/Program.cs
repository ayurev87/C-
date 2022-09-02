// Задача 30. Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];


// void GetRandom(int[] arr)
// {
//     int count = arr.Length;
//     for ( int i = 0; i < count; i++)
//     {
//         arr[i] = new Random().Next(0,2);
//     } 
//  }

int[] NewArray()
{
    int[] arr = new int[8];
    for ( int i = 0; i < arr.Length; i++)
    {
        Random rmd = new Random();
        arr[i] = rmd.Next(0,2);
    } 
    return arr;
 }

 void PrintArray(int []arr)
 {
    Console.Write("[");
    for(int i = 1; i < arr.Length; i++)
    {
        if(i < arr.Length-1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
 }
//  GetRandom(array);



int[] array = NewArray();
//  PrintArray(array);
//  void PrintArray()
//  {
//     int count = array.Length;
//     Console.Write(array[0]);
//     for(int i = 1; i < count; i++)
//     {
//         Console.Write(" ," + array[i]);
//     }
//  }
PrintArray(array);
