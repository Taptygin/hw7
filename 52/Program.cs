/*  Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
void PrintArray(int[,] mArray)
{
    for (int i = 0; i < mArray.GetLength(0); i++)
    {
        for (int j = 0; j < mArray.GetLength(1); j++)
        {
            Console.Write($"{mArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
double[] resultArif(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int column = 0; column < array.GetLength(1); column++)
    {
        double sum = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            sum += array[row, column];
        }
        result[column] = Math.Round(sum / array.GetLength(0), 2);
    }
    return result;
}

Console.Clear();

Console.Write("Введите количество строк:");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[] averageColumns = resultArif(array);
Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join(";", averageColumns)}");