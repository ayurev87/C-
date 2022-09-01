// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число (N): ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1) Console.WriteLine("Введены некорректное число");
else
{
    for(int i = 1; i <= n; i++)
    {
        Console.WriteLine(i + " | " + Math.Pow(i,3));
    }
}