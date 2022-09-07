// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble (int size, int min, int max)
{
    double[] arr = new double[size];
    Random rdm = new Random();
    for (int i = 0; i < size; i++)
    {
        if (min == 0) arr[i] = rdm.NextDouble()*max;
        else if (min < 0) arr[i] = rdm.NextDouble() *2*max + min;
        else arr[i] = rdm.NextDouble()*(max -min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++ )
    {
        if( i < arr.Length - 1) 
        {
            Console.Write("{0:0.0}" ,arr[i]);
            Console.Write(", ");
        }
        else 
        {
            Console.Write("{0:0.0}" ,arr[i]);
            Console.WriteLine(" ]");
        }
    }
}

double DiffMaxMinDouble(double[] array)
{
    double min = array[0], max = array[0]; 
    for( int i =1; i< array.Length; i++)
    {
        if ( min > array[i]) min = array[i];
    }
    for( int i =1; i< array.Length; i++ )
    {
        if ( max < array[i]) max = array[i];
    }
    return   max - min;
  
}

double[] array = CreateArrayRndDouble(5, 0, 100);
PrintArray(array);
double result = DiffMaxMinDouble(array);
Console.Write("Между ними разницы -> ");
Console.WriteLine("{0:0.0}", result);