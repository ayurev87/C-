// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 7 || day <= 0) Console.WriteLine(day + " Число не существует в неделя");
else if (day == 6 || day == 7) Console.WriteLine($"Число {day} день является выходным");
else Console.WriteLine($"Число {day} день не является выходным");