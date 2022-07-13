/*Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] GenerateArray(int m=3, int n=4)
{
    int[,] res = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i,j] = new Random().Next(0,10); 
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
            System.Console.Write($"{array[i,j]}\t");
        }
    }
    System.Console.WriteLine();
}

(int i, int j) Promt (string message)
{
    string line;
    string[] parts;
    var result = (i:0, j:0);
    System.Console.Write(message);
    line = Console.ReadLine();
    parts = line.Split(',');
    result.i = int.Parse(parts[0]);
    result.j = int.Parse(parts[1]);
    return result;
}

void ValueInArray (int[,] array, (int i, int j) postion)
{
    if(postion.i <= array.GetLength(0) && postion.j <= array.GetLength(1) && postion.i > 0 && postion.j > 0)
        {
             System.Console.WriteLine("Value = " + array[postion.i-1,postion.j-1]);
        }
    else  System.Console.WriteLine("This element doen't exist");
}
int[,] myArray = GenerateArray();
PrintArray(myArray);
(int,int) position = Promt("Enter position in array separated by comma( for emxample: 1,1 ): ");

ValueInArray(myArray, position);