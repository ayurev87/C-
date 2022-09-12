// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите число b на первой прямой: ");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k на первой прямой: ");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b на первой прямой: ");
float b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k на второй прямой: ");
float k2 = Convert.ToInt32(Console.ReadLine());


float[] IntersectionTwoLines(float a1, float b1, float a2, float b2)
{
    float[] arr = new float[2];
    arr[0] = (b2-b1)/(a1-a2);
    arr[1] = a1*arr[0]+b1;
    return arr;
}

float[] result = IntersectionTwoLines(k1, b1, k2, b2);
Console.WriteLine($"Пересечение двух прямых точек ({result[0]}; {result[1]} )");