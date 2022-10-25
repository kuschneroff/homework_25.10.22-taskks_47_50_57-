﻿/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void FillArrayRandomNumbers(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-1000, 1000)) / 10;
        }
    }
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5:f1} |");
        }
        Console.WriteLine();
    }
}
int m = GetNumber("Введите количество строк: ");
int n = GetNumber("Введите количество столбцов: ");
double[,] matrix = new double[m, n];
FillArrayRandomNumbers(matrix);
Console.WriteLine();
PrintMatrix(matrix);