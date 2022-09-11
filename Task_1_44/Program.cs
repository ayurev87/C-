// Задача 44. не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N= 5 -> 01123
// Если N= 3 -> 011
// Если N= 7 -> 0112358

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

void ShowFibonacci(int num)
{
    int num1 = 0;
    int num2 = 1;
    int temp = 0;
    Console.Write($"{num1} ");

    for (int i = 1; i < num; i++)
    {
        Console.Write($"{num2} ");
        temp = num2;
        num2 = num1 + num2;
        num1 = temp;

    }
}
ShowFibonacci(number);