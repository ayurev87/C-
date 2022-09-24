// Задача 69. Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии.
// А = 3, В = 5 -> 243 (3 в 5)
// А = 2, В = 3 -> 8 ( 2 в 3)

Console.Write("Введите положительное целое число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое положительное степень В: ");
int b = Convert.ToInt32(Console.ReadLine());

int Dergy(int a, int b)
{
    int dergy = 1;
    if (b == 0) return dergy;
    return a * Dergy(a, b - 1);
}

int result = Dergy(a,b);
Console.WriteLine($"A = {a}, B = {b} -> {result}");