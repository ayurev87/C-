Console.Write("Введите целое число: ");
int num = Convert.ToInt32(System.Console.ReadLine());

Console.Write("Вывод чисел в промежутку от -N до N: " + -num);

for (int i = -num + 1 ; i <= num; i++ )
{
    Console.Write(", " + i);
}