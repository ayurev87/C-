// Задача 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigitals(int num)
{   
    int sum = num%10;
    if(num == 0) return sum;
    return SumDigitals(num/10) + sum;
    
}

Console.WriteLine($"{number} -> {SumDigitals(number)}");