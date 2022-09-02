// 24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("введите целое положительное число(А): ");
int a = Convert.ToInt32(Console.ReadLine());

// string GetSumA(int a)
// {
//     if (a > 0)
//         {
//             int sum =0;
//             for( int i = 1; i <= a ; i++ )
//             {
//                 // sum = sum + i;
//                 sum += i;
//             }
//             return sum.ToString();
//         }
//     return "Некорректный ввод. Требуется положительное число";
// }

// string res = GetSumA(a);
// Console.WriteLine($"Сумма чисел от 1 до {a} = {res}");

int GetSumA(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        // sum = sum + i;
        sum += i;
    }
    return sum;
}

if (a > 0)
{
    int res = GetSumA(a);
    Console.WriteLine($"Сумма чисел от 1 до {a} = {res}");
}
else Console.WriteLine("Некорректный ввод. Требуется положительное число");