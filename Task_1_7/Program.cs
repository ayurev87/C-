Console.Write("Введите числа: ");
int num = Convert.ToInt32(System.Console.ReadLine());
if ( num < 0)
{
    Console.WriteLine($"Вывод последние числа из них: {-num % 10}");
}
else Console.WriteLine($"Вывод последние числа из них: {num % 10}");
