
int[,] matrix1 = FillArray(3, 2, 1, 10);
int[,] matrix2 = FillArray(2, 3, 1, 10);
Print2dArray(matrix1);
System.Console.WriteLine();
Print2dArray(matrix2);
System.Console.WriteLine();
int[,] result = MultiplyMatrix(matrix1, matrix2);
if (result.GetLength(0) == 0)
    System.Console.WriteLine("Матрицы не согласованы");
else
    Print2dArray(result);

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);
    if (rows2 != columns1)
        return new int[0, 0];
    int[,] result = new int[rows1, columns2];
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < columns1; k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }

        }
    }
    return result;
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