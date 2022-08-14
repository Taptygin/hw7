/*  Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
void PrintArray(int[,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            Console.Write($"{MyArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
bool FindElement(int[,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == el) return true;
        }
    }
    return false;
}

Console.Clear();
Console.Write("Введите количество строк:");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine());

int[,] Array = GetArray(rows, columns, 0, 10);
PrintArray(Array);

Console.Write("Введите значение элемента:");
int element = int.Parse(Console.ReadLine());

if (FindElement(Array, element))
{
    Console.WriteLine("Такой элемент есть в массиве.");
}
else
{
    Console.WriteLine("Такого элемента нет в массиве.");
}