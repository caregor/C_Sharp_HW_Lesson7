/* Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] GenerateArray(int m = 3, int n = 4)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(0, 10);
        }
    }
    return res;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

double[] AvarageInColumn(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ = summ + (double)array[i, j];
        }

        result[j] = summ / (double)array.GetLength(0);
    }
    return result;
}

void PrintAvarage(double[] array)
{
    foreach (double item in array)
    {
        System.Console.Write($"{item:F}\t");
    }
    System.Console.WriteLine();
}

int[,] myArray = GenerateArray();
PrintArray(myArray);

double[] avarage = AvarageInColumn(myArray);
System.Console.WriteLine("------Avg in Column------");
PrintAvarage(avarage);
