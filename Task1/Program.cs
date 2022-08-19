Console.Write("Введите квадрат число: ");
int square = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
if (square == result) 
{
    Console.WriteLine($"a = {square}, b = {num} -> да");
}
else
{
    Console.WriteLine($"a = {square}, b = {num} -> нет");
}

