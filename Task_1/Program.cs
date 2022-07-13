/*Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double[,] GenerateArray(int m, int n)
{
    double[,] res = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i,j] = new Random().NextDouble() * 10; 
        }
    }
    return res;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]:F}\t");
        }
    }
    System.Console.WriteLine();
}

int rows = Prompt("enter rows: ");
int columns = Prompt ("enter comlumns: ");
double[,] TwoDimentionArray = GenerateArray(rows,columns);
PrintArray(TwoDimentionArray);
