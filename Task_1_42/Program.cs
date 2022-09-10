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
while (number > 0)
{
    int num1 = number % 2;
    Console.WriteLine(num1);
    number /=2;
}







