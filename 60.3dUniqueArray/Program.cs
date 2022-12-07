// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] arr = Fill3dArrayUnique(2, 2, 2, 1, 10);
if (arr.GetLength(0) == 0)
    System.Console.WriteLine("Недостаточный диапазон чисел для уникальности");
else
    Print3dArray(arr);


int[,,] Fill3dArrayUnique(int rows, int columns, int depth, int min = 0, int max = 10)
{
    if ((max - min) < rows * columns * depth)
        return new int[0, 0, 0];

    Random rand = new Random();
    int[,,] result = new int[rows, columns, depth];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                int newItem = rand.Next(min, max);
                while (ArrayContain(result, newItem))
                    newItem = rand.Next(min, max);

                result[i, j, k] = newItem;
            }

        }
    }
    return result;
}

bool ArrayContain(int[,,] arr, int findItem)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j, k] == findItem)
                    return true;
            }
        }
    }
    return false;
}

void Print3dArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                System.Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
    }
}