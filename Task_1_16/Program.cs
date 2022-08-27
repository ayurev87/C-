// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число  квадратом другого.
// 5, 25 - > да
// -4, 16 - > да
// 25, 5 - > да
// 8, 9 - > нет

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

    if (a*a == b || b*b == a) Console.WriteLine("одно число является квадратом другого");
    else Console.WriteLine("одно число не является квадратом другого");
