/*
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,] InitMatrixArray(int a, int b)
{
    int[,] resultMatrixArray = new int[a, b];
    Random rnd = new Random();

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            resultMatrixArray[i, j] = rnd.Next(1, 10);
        }
    }
    return resultMatrixArray;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5:f0} ");
        }
        Console.WriteLine();
    }
}
double[] GetAverage(int[,] resultAverage)
{
    double[] arrayAvg = new double[resultAverage.GetLength(1)];
    int summ = 0;
    for (int j = 0; j < resultAverage.GetLength(1); j++)
    {
        for (int i = 0; i < resultAverage.GetLength(0); i++)
        {
            summ += resultAverage[i, j];
        }
        arrayAvg[j] = (double)summ / resultAverage.GetLength(0);
        summ = 0;
    }
    return arrayAvg;
}


int a = GetNumber("Введите количество строк в двумерном массиве: ");
int b = GetNumber("Введите количество столбцов в двумерном массиве: ");
int[,] resultAverage = InitMatrixArray(a, b);
PrintMatrix(resultAverage);
double[] avg = GetAverage(resultAverage);
Console.WriteLine();
Console.WriteLine($"Среднеарифметическое {string.Join(";  ",avg)}");