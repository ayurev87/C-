// 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X не равно 0 и Y не равно 0 т выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Введите координаты точка на X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точка на Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Точка находится на первой четверти");
// else if (x < 0 && y > 0) Console.WriteLine("Точка находится на второй четверти");
// else if (x > 0 && y < 0) Console.WriteLine("Точка находится на четрвёртной четверти");
// else if (x < 0 && y < 0) Console.WriteLine("Точка находится на третьей четверти");
// else Console.WriteLine("Введены некорректные коордианты");

string GetQuarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Точка находится на первой четверти";
    if (xc < 0 && yc > 0) return "Точка находится на второй четверти";
    if (xc > 0 && yc < 0) return "Точка находится на четрвёртной четверти";
    if (xc < 0 && yc < 0) return "Точка находится на третьей четверти";
    return "Введены некорректные коордианты";
}

// string result = GetQuarter(x, y);
// string result1 = GetQuarter(5, 8);
// string result2 = GetQuarter(-7, y0);

int i = 0;
string[] array = new string[5];
while (i < array.Length)
{
    Console.Write($"Введите координаты точка {i+1} на X: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите координаты точка {i+1} на Y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    array[i] = GetQuarter(x, y);
    Console.WriteLine(array[i]);
    Console.WriteLine();
    i++;
}

// Console.WriteLine(result);
// Console.WriteLine(result1);
// Console.WriteLine(result2);