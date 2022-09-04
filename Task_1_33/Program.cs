// Задача 33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
// 4; массив [6, 7, 19, 345, 3] - нет
// 3; массив [6, 7, 19, 345, 3] - да

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

// string FindNumberFavorite(int[] array, int num)
// {
//     for(int i = 0; i< array.Length; i++)
//     {
//         if ( array[i] == num) return "ДА";
//     }
//     return "Нет";
// }

bool FindNumberFavorite(int[] array, int num)
{
    bool j = false;
    for(int i = 0; i< array.Length; i++)
    {
        if ( array[i] == num) 
        {
            j = true;
            break;
        }
    }
    return j;
}


 Console.Write("Введите целое положительное число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 int[] array = CreateArrayRndInt(5, 1, 9);
 bool j = FindNumberFavorite(array, number);
// string result = j?"Да": "Нет";
PrintArray(array);
//  Console.WriteLine(" Заданное число:" + number + " : " + result);
Console.WriteLine(j?"Да": "Нет");