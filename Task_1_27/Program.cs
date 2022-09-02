

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
try
{
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int numbers)
{
    int count = numbers.ToString().Length;
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        sum = sum + numbers % 10;
        numbers /= 10;
    }
    return sum;
}
Console.WriteLine($"{num} число сумму цифр в числе: {SumNumbers(num)}");
}
catch
{
    Console.WriteLine("Некорректное число, требует маскимальные 10 цифра в числе");
}