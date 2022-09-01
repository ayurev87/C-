// Задача 22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N
try
{
    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("Введены некорректное значение");
    // else
    // {
    //     int count = 0;
    //     Console.Write( Math.Pow(1, 2));
    //     while (count < n)
    //     {
    //         count++;
    //         Console.Write(", " + Math.Pow(count+1, 2));
    //     }
    // }
    else
    {
        for (int i = 1; i <= n; i++)
            Console.WriteLine($" {i}\t{Math.Pow(i, 2)}");
        
    }
}
catch
{
    Console.WriteLine("Введены некорректное значение");
}