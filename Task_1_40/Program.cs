// Задача 40: Напишите программу, которая принимает на вход три числа и проверяетб может ли 
// существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Введите сторону A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону В: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону С: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
    
}

// if (a < b + c & b < a + c & c < a + b)
//     {
//         Console.WriteLine("Является треугольником");
//     }
//     else Console.WriteLine("Не является треугольником");

bool result = Triangle(num1,num2,num3);
Console.WriteLine(result? "Является треугольником" : "Не является треугольником");