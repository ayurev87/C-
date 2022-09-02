// Задачу 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int q = Convert.ToInt32(Console.ReadLine());
string Range(int quarter)
{
    if (quarter == 1) return " x > 0 и y > 0";
    if (quarter == 2) return " x < 0 и y > 0";
    if (quarter == 3) return " x < 0 и y < 0";
    if (quarter == 4) return " x > 0 и y < 0";
    return "Введены некорректное значение";
}
string result = Range(q);
Console.WriteLine(result);