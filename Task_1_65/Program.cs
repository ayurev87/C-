// Задача 65:  Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M =1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

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

void NaturalNumber(int a, int b)
{
            if(a >= b )
        {     
            Console.Write($"{b}, ");
            if(a == b) return;
            NaturalNumber(b+1, a);
   
        }
        else 
        {
            Console.Write($"{a}, ");
            if(a == b) return;
            NaturalNumber(a+1, b);
        }
}
NaturalNumber(num1, num2);