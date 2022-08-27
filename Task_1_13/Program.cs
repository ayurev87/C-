// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = new Random().Next(10,999999);
Console.WriteLine("Случайно числа выпадает: " + num);
// int cont = 100;
// if ( num/cont == 0) Console.WriteLine("Третьй цифры нет");
// else 
// {
//     while ( num/cont > 0) 
//     {
//         cont=cont*10;
//     }
//     int num1 = num/(cont/1000);
//     int result =num1 - (num1/10*10);
//     Console.WriteLine("Третий цифр: " + result);
// }
string Third (int numer)
{
    int cont = 100;
    if ( numer/cont == 0) 
        return ("Третьй цифры нет");
    else 
    {
        while ( num/cont > 0) 
        {
            cont=cont*10;
        }
        int num1 = num/(cont/1000);
        int result =num1 - (num1/10*10);
        return ("Третий цифр: " + result);
    }
}
string result = Third(num);
Console.WriteLine(result);