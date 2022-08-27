// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Решить без использования строк.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Введите трёхзначеное число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

//  while (num3 / 100 == 0)
//  {
//     if (num3/100 == 0) 
//     {
//         Console.WriteLine(" Не соотствует трёхзначенное число,");
//         Console.Write(" Снова введите трёхзначное число: ");
//         num3 = Convert.ToInt32(Console.ReadLine());
//     }
//  }
//  int num1 = num3/100*10;
//  int num2 = num3<0 ? -((num3/10)- num1):  (num3/10)- num1;

 int Sred (int num)
 {
    while (num / 100 == 0)
    {
        if (num/100 == 0) 
        {
            Console.WriteLine(" Не соотствует трёхзначенное число,");
            Console.Write(" Снова введите трёхзначное число: ");
            num = Convert.ToInt32(Console.ReadLine());
        }
    }
    int num1 = num/100*10;
    return num<0 ? -((num/10)- num1):  (num/10)- num1;
 }

int result = Sred (num3);

 Console.WriteLine($"Вывод вторую цифр : {result}");
