// 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного  копирования.

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

int[] ReturnArray(int[] arr)
{
    int[] arr1 = new int[arr.Length];
    for(int i = 0; i< arr.Length; i++)
    {
        arr1[i] = arr[i];
    }
    return arr1;
}

int[] array1 = CreateArrRndInt(10, 1, 20);
PrintArray(array1);
int[] array2 = ReturnArray(array1);
PrintArray(array2);
Console.WriteLine("Изменение второе значение в массивеб чтоб определить копированный массив");
array1[1] = 40;
PrintArray(array1);
PrintArray(array2);