Console.Clear();

void SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int temp;
        for (int k = 1; k < arr.GetLength(1); k++)
        {
            for (int j = 1; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] < arr[i, j - 1])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, j - 1];
                    arr[i, j - 1] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($" {arrayToPrint[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

int rows = 4;
int columns = 10;
int leftRange = 1;
int rightRange = 10;
int[,] matrix = CreateArray(rows, columns, leftRange, rightRange);
PrintArray(matrix);
SortArray(matrix);
Console.WriteLine();
PrintArray(matrix);