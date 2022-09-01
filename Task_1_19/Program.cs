// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int k = 321;
//             Console.WriteLine(k.ToString().Reverse().ToArray());
// int num = 12345;
// int ReverseInt(int num)
// {
//     int result = 0;
//     while(num>0)
//     {
//         result=result*10+num%10;
//         num = num/10;
//     }
//     return result;
// }
// Console.WriteLine(num);
// int num2 =ReverseInt(num);
// Console.WriteLine(num2);

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

string GetPalindrom(int number)
{
    if (9999 < number && 100000 > number)
    {
        int count = number;
        int number2 = 0;
        while (count > 0)
        {
            number2 = number2 * 10 + count % 10;
            count /= 10;
        }
        if (number == number2) return "Является палиндромом";
        return "Не является палиндромом";
    }
    return "Некорректное значение";
}

string res = GetPalindrom(num);
Console.WriteLine(res);