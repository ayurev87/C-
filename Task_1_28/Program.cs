// Задача 28. Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());

double GetMultiplied (int number)
{   
    double product = 1;
    for (int i = 1; i <= number; i++ )
    {
        product *=i;
    }
    return product;
}
 if (n <= 0) Console.WriteLine("Введенное некорректное число, требует положительное число от 1");
 else 
 {
    double result = GetMultiplied(n);
    Console.WriteLine($"Приозведение чисел от 1 до {n} = {result}");
 }