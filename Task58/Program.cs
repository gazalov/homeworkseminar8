Console.Clear();


int[,] MultiplyArrays(int[,] arr1, int[,] arr2)
{
    int[,] multArray = new int[arr1.GetLength(0), arr1.GetLength(0)];
    int i = 0;
    int j = 0;
    multArray[0, 0] = arr1[i, j] * arr2[i, j] + arr1[i, i + 1] * arr2[i + 1, i];
    multArray[1, 0] = arr1[i + 1, j] * arr2[i, i] + arr1[i + 1, i + 1] * arr2[i + 1, i];
    multArray[0, 1] = arr1[i, j] * arr2[i, j + 1] + arr1[i, i + 1] * arr2[i + 1, i + 1];
    multArray[1, 1] = arr1[i + 1, i] * arr2[i, i + 1] + arr1[i + 1, i + 1] * arr2[i + 1, i + 1];

    return multArray;
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
int rows = 2;
int columns = 2;
int leftRange = 1;
int rightRange = 10;
int[,] array1 = CreateArray(rows, columns, leftRange, rightRange);
int[,] array2 = CreateArray(rows, columns, leftRange, rightRange);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
int[,] multArray = MultiplyArrays(array1, array2);
PrintArray(multArray);