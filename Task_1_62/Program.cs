// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

bool Recursiya(int i, int j, int index, int count, int[] DelRow, int[] DelCol)
{
    bool result = false;
    if(index == count) return true;
    if(i != DelRow[index] && j != DelCol[index])
    {
        index++;
        result = Recursiya(i,j,index,count,DelRow,DelCol);
       
    }
    return result;
}
int[] array1 = {2,5};
int[] array2 = {6,3};
Console.WriteLine(Recursiya(1, 4, 0, 2, array1, array2));
