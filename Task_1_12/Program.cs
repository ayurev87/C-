//Напишите программу, которая  будет принимать на вход два числа и выводить, является ли  второе число кратными  первому. 
// Если 2 число не кратно число 1, то программа выводит остаток 4

Console.Write("Вводите первое число: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Вводите второе число, кроме число 0: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int res = num1 % num2;
if( res == 0) Console.WriteLine($"{num1}, {num2} является кратными");
else Console.WriteLine($"{num1}, {num2} не является кратными, остаток {res}");