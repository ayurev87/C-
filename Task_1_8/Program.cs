﻿// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (a<=1) Console.Write(" Вывод нулевое число");

Console.Write($"Вывод все чётные чисел до {a}: " );
while (i <=a)
{
    Console.Write( i + " ");
    i=i+2;
    
}