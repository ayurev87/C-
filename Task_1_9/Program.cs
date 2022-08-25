int number = new Random().Next(10, 100);
Console.WriteLine("Случайное число из диапазона 10-99 = " + number);

// int FirstDigit = number / 10;
// int SecondDigit = number % 10;

// // if ( FirstDigit > SecondDigit) Console.WriteLine($"Наибольше цифра чисел {number}: " + FirstDigit);
// // else if (FirstDigit < SecondDigit) Console.WriteLine($"Наибольше цифра чисел {number}: " + SecondDigit);
// // else Console.WriteLine(" Цифры равны: " + FirstDigit); 

// string result = FirstDigit == SecondDigit ? "Цифра равны" : FirstDigit > SecondDigit ? FirstDigit.ToString() : SecondDigit.ToString();
// Console.WriteLine($"Наибольше цифра чисел {number}: " + result);


int Max(int num) 
{
    int FirstDigit = num / 10;
    int SecondDigit = num % 10;
    if (FirstDigit == SecondDigit) return 0;
    return FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
}

int result = Max(number);
string res = result == 0 ? "Цифра равны" : result.ToString();
Console.WriteLine("наибольшое число: " + res);
