// Задача 26. Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.Write("Введите целого число: ");
double num = Convert.ToInt64(Console.ReadLine());


// int GetCount(double number)
// {
//     string count = number.ToString();
//     return count.Length;
// }
// 1.Вариант . Органичен до 9 количества число.

// int GetCount(double number)
// {
//     int i = 0;
//     for (i = 0; 1 <= number; i++ )
//     {
//         number /=10;
//     }
//     return i;
// }
// 2. Вариант

int GetCount(double number)
{
    if(number<0) number = - number;
    int i = 0;
   while ( 1 <= number)
   {
    number /=10;
    i++;
   }
    return i;
}



int result = GetCount(num);
Console.Write($"Введенное число {num} состоит из {result} цифр.");

