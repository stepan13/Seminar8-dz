//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] arr = FillArray(4, 5);
Print2dArray(arr);
System.Console.WriteLine();
SortLinesInArray(arr);
Print2dArray(arr);

// void SortLines(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         SortArray(arr.GetValue(i));
//     }
// }


void SortLinesInArray(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < columns; col++)
        {
            for (int k = col + 1; k < columns; k++)
            {
                if (arr[row, k] > arr[row,col])
                {
                    int temp = arr[row, col];
                    arr[row, col] = arr[row, k];
                    arr[row, k] = temp;
                }
            }
        }
    }
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
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}