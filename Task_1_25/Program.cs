// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите числа А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числа B: ");
int b = Convert.ToInt32(Console.ReadLine());

double GetPow()
{   
    int pow = 1;
    int index = 0;
    while (index < b)
    {
        pow = pow *a;
        index++;
    }
    return pow;
}

double result = GetPow();
Console.WriteLine($"Число {a} в натуральную степень {b} = {result}");