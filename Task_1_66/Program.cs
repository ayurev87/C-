// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int num2 = Convert.ToInt32(Console.ReadLine());

// void NaturalNumber(int num)
// {
//      for (int i = 1; i <= num; i++)
//     {
//        Console.Write(i!=num? $"{i}, " : $"{i}");
//     }
// }

int SumNaturalNumber(int m, int n, int sum)
{
    if (m > n) return sum;
    return SumNaturalNumber(m + 1, n, sum += m);
}
int result=0;
if (num1 < num2)
{
  result = SumNaturalNumber(num1, num2, 0);  
  Console.WriteLine($"M = {num1}, N = {num2} -> {result}");
} 
else
{ result = SumNaturalNumber(num2, num1, 0);
Console.WriteLine($"M = {num2}, N = {num1} -> {result}");
}