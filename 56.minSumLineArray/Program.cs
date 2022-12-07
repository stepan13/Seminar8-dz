// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] arr = FillArray(4, 5);
Print2dArray(arr);
int result = FindMinSumLine(arr);
System.Console.WriteLine($"Минимальная сумма в строке с индексом {result}");
int FindMinSumLine(int[,] arr)
{
    int minSumRow = 0;
    int minSum = 0;
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        int RowSum = 0;
        for (int col = 0; col < arr.GetLength(1); col++)
        {
            RowSum += arr[row, col];
        }

        if (row == 0)
            minSum = RowSum;
        else if (RowSum < minSum)
        {
            minSum = RowSum;
            minSumRow = row;
        }

    }
    return minSumRow;
}


int[,] FillArray(int rows, int columns, int min = 0, int max = 10)
{
    Random rand = new Random();
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rand.Next(min, max);
        }
    }
    return result;
}

void Print2dArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
            System.Console.Write($"{i}: ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}