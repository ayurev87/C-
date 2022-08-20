Console.Write("Введите целое число: ");
int num = Convert.ToInt32(System.Console.ReadLine());
if (num <0) num = -num;
int num1 = num;
Console.Write("Вывод чисел в промежутку от -N до N: " + -num);

for (int i = -num + 1 ; i <= num; i++ )
{
    Console.Write(", " + i);
}
Console.WriteLine("");
 int num2 = -num1;
 Console.Write(-num1);
  
while (num2 < num1)
{
    num2++;
    Console.Write($", {num2}");

}