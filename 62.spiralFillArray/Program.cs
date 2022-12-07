//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
int rows = AskIntNumber("Рядов: ");
int columns = AskIntNumber("Колонок: ");

int[,] arr = FillSpiral(rows, columns);
Print2dArray(arr);
int[,] FillSpiral(int rows, int columns)
{
    int startRow = 0;
    int startCol = 0;
    int endRow = rows;
    int endCol = columns;
    int directionRow = 1;
    int directionCol = 1;
    int currentCol = 0;
    int currentRow = 0;
    int[,] result = new int[rows, columns];
    int count = 0;
    bool fillingRow = true;
    while (startRow < endRow && startCol < endCol)
    {
        count++;
        result[currentRow, currentCol] = count;
        if (fillingRow)
        {
            currentCol += directionCol;
            if (currentCol == endCol || currentCol == startCol - 1)
            {
                fillingRow = false;
                if (directionCol == 1)
                    startRow++;
                else
                    endRow--;

                directionCol = -directionCol;
                currentCol += directionCol;
                currentRow += directionRow;
            }
        }
        else
        {
            currentRow += directionRow;
            if (currentRow == endRow || currentRow == startRow - 1)
            {
                fillingRow = true;
                if (directionRow == 1)
                    endCol--;
                else
                    startCol++;

                directionRow = -directionRow;
                currentRow += directionRow;
                currentCol += directionCol;
            }
        }
    }
    return result;
}

string GetFormatString(int size)
{
    string formatString = string.Empty;
    while (size > 0)
    {
        formatString += "0";
        size /= 10;
    }
    return formatString;

}

void Print2dArray(int[,] arr)
{
    
    string formatString = GetFormatString(arr.GetLength(0)*arr.GetLength(1));
    string formatStringN = GetFormatString(arr.GetLength(0));

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write($"{i.ToString(formatStringN)}: ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j].ToString(formatString)} ");
        }
        System.Console.WriteLine();
    }
}

int AskIntNumber(string WelcomeText)
{
    Console.Write(WelcomeText);
    string input = Console.ReadLine() ?? string.Empty;
    return Convert.ToInt32(input);
}