// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!")

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.WriteLine($"Квадрат числа {num} = {square}");