// Напишете программу, которая выводит случайнре трёхзначенное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);
int FirstDigit = number / 100;
int SecondDigit = number % 10;

 Console.WriteLine("Трёхзначенное число: " + number);
// Console.WriteLine($"Убрать вторую цифру и получилось: {FirstDigit}{SecondDigit}");
 int enter = FirstDigit *10 + SecondDigit;

Console.WriteLine($"Убрать вторую цифру и получилось: {enter}");