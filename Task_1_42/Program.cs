// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двойчное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

//краткое проще 1 вариант.
// void Main(int val)
// 	{
// 		string binary = Convert.ToString(val, 2);

// 		Console.WriteLine(binary);
// 	}
// Main(number);


 // 2  вариант
// int GetIO(int num)
// {
//     int result = 1;
//     while (number > 0)
//     {
//         result += number % 2;
//         number /= 2;
//         result *= 10;
//     }
//     int result1 = 0;
//     while (result > 0)
//     {
//         result1 = result1 * 10 + result % 10;
//         result /= 10;
//     }
//     result1 -= 1;
//     return result1;
// }


// int res = GetIO(number);
// Console.WriteLine(res);

//3 вариант используется факториала.
// void PrintArray10(int[] arr, int num)
// {
//     Console.Write($"{num} -> ");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]);
//     }
// }

// int[] array10(int number)
// {
//     int n = 1;
//     int size = 0;
//     while (n <= number)
//     {
//         n += n;
//         size++;
//     }
//     int[] arr = new int[size];
//     int i = 0;
//     while (number > 0)
//     {
//         arr[size - 1 - i] = number % 2;
//         number /= 2;
//         i++;
//     }
//     return arr;
// }


// int[] array = array10(number);
// PrintArray10(array, number);

// 4 вариант
// int result = 0;
// int mult = 1;
// while (number > 0)
// {
//     result += number%2 *mult;
//     number/=2;
//     mult*=10;
// }

// Console.WriteLine(result);


// 5 варинат рекурсия
void DecToBin(int num)
{
    if(num==0) return;
    DecToBin(num /2);
    Console.Write(num%2);
}

DecToBin(number);


