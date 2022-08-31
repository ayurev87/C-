Console.Write("Введите координаты X для точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y для точки A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты X для точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y для точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xc1, int yc1, int xc2, int yc2)
{
    return Math.Sqrt(Math.Pow((xc2-xc1),2) + Math.Pow((yc2-yc1),2));
}

// double result = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
// Console.WriteLine("Расстояние между точками: {0: #.##}",result);

double res = Distance(x1, y1, x2, y2);
Console.Write("Расстояние между точками: ");
Console.WriteLine(Math.Round(res,3));