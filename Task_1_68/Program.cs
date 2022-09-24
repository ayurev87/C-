// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
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

int Akkermana(int number, int argument)
{
    if (number == 0) return argument + 1;
    else
      if ((number != 0) && (argument == 0))
      return Akkermana(number - 1, 1);
    else
      return Akkermana(number - 1, Akkermana(number, argument - 1));

}

int result = Akkermana(num1, num2);
Console.WriteLine($"m = {num1}, n = {num2} -> A(m,n) = {result}");