// Задача 39. Напишите программу, которая перевернёт одномерный масиив
// (последний элемент будет на первом местеб а первый - на последнем и.т.д)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] - > [6 3 7 6]

// Array.Reverse(arr);

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
        else Console.WriteLine(arr[i] + " ]");
    }
}

int[] array = CreateArrRndInt(13, 1, 10);
PrintArray(array);

// upend - переверёнуть


void ReversArray(int[] arr)
{
    int size = arr.Length;
    int index1 = 0; 
    int index2 = size-1;
    while( index1 < index2)
    {
        int obj = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = obj;
        index1++;
        index2--;
    }

}

void ReversArray1( int[] arr)
{
    int size = arr.Length;
    for(int i =0; i < size/2; i++)
    {
        int temp = array[i];
        array[i] = array[size-1-i];
        array[size-1-i] = temp;
    }
}

ReversArray1(array);
// Array.Reverse(array);
PrintArray(array);