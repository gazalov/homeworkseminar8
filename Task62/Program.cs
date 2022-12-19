Console.Clear();

int dimension = EnterData("Введите размер стороны квадратного двумерного массива для заполнения по спирали: ");
int rows = dimension;
int columns = dimension;
int number = 1;
int row = 0;
int column = 0;
int[,] array = new int[rows, columns];

void PrintArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write("{0}\t", arrayToPrint[i, j].ToString("00"));
        }
        Console.WriteLine();
    }
}

void StartSpiral()
{
    if (number <= dimension * dimension)
    {
        MoveDown(array, row, column, number, out number, out row, out column);
        MoveLeft(array, row, column, number, out number, out row, out column);
        MoveUp(array, row, column, number, out number, out row, out column);
        MoveRight(array, row, column, number, out number, out row, out column);
        StartSpiral();
    }
}

void MoveUp(int[,] array, int rowIn, int columnIn, int data, out int number, out int row, out int column)
{
    int i;
    int count = 0;
    for (i = rowIn - 1; i > 0; i--)
    {
        if (array[i, columnIn] == 0)
        {
            array[i, columnIn] = data;
            count = i;
            data++;
        }
    }
    number = data;
    row = count;
    column = columnIn;
}

void MoveLeft(int[,] array, int rowIn, int columnIn, int data, out int number, out int row, out int column)
{
    int k;
    int count = 0;
    for (k = columnIn - 1; k >= 0; k--)
    {
        if (array[rowIn, k] == 0)
        {
            array[rowIn, k] = data;
            count = k;
            data++;
        }
    }
    number = data;
    row = rowIn;
    column = count;
}

void MoveDown(int[,] array, int rowIn, int columnIn, int data, out int number, out int row, out int column)
{
    int i;
    int count = 0;
    for (i = rowIn; i < array.GetLength(0) - rowIn; i++)
    {
        if (array[i, columnIn] == 0)
        {
            array[i, columnIn] = data;
            count = i;
            data++;
        }
    }
    number = data;
    row = count;
    column = columnIn;
}

void MoveRight(int[,] array, int rowIn, int columnIn, int data, out int number, out int row, out int column)
{
    int j;
    int count = 0;
    for (j = columnIn; j < array.GetLength(0) - 1; j++)
    {
        if (array[rowIn, j] == 0)
        {
            array[rowIn, j] = data;
            count = j;
            data++;
        }
    }
    number = data;
    column = count;
    row = rowIn;
}

void MoveRightFirstRow(int[,] array, int rowIn, int columnIn, int data, out int number, out int row, out int column)
{
    int j = 0;
    while (j < array.GetLength(0))
    {
        array[rowIn, j] = data;
        data++;
        j++;
    }
    number = data;
    column = j - 1;
    row = rowIn;
}

int EnterData(string message)
{
    Console.Write(message);
    int inputData = int.Parse(Console.ReadLine());
    return inputData;
}

MoveRightFirstRow(array, row, column, number, out number, out row, out column);
StartSpiral();
PrintArray(array);
