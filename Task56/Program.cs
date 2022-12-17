Console.Clear();

void PrintRowMin(int[] arrMin)
{
    int rowMin = arrMin[0];
    int rowNumber = 0;
    for (int i = 0; i < arrMin.Length; i++)
    {
        if (arrMin[i] < rowMin)
        {
            rowMin = arrMin[i];
            rowNumber = i;
        }
    }
    System.Console.WriteLine($"Строка с наименьшей суммой элементов двухмерного массива: {rowNumber}.");
}

void PrintArrSum(int[] arraySum)
{
    for (int i = 0; i < arraySum.Length; i++)
    {
        Console.WriteLine(arraySum[i]);
    }
}

int[] SumRows(int[,] arr)
{
    int sum = 0;
    int[] arraySum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        arraySum[i] = sum;
    }
    return arraySum;
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
int columns = 3;
int leftRange = 1;
int rightRange = 10;
int[,] matrix = CreateArray(rows, columns, leftRange, rightRange);
Console.WriteLine("Первоначальный двухмерный массим:");
PrintArray(matrix);
int[] arrayOneDimension = SumRows(matrix);
Console.WriteLine();
Console.WriteLine("Одномерный массив со значениями сумм строк первоначального массива:");
PrintArrSum(arrayOneDimension);
Console.WriteLine();
PrintRowMin(arrayOneDimension);