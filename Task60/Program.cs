Console.Clear();

bool CheckDoubleElement(int[,,] arrayToCheck, int refNumber)
{
    bool check = false;
    for (int i = 0; i < arrayToCheck.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToCheck.GetLength(1); j++)
        {
            for(int k = 0; k < arrayToCheck.GetLength(2); k++)
            {
                if (arrayToCheck[i, j, k] == refNumber)
                {
                    check = true;
                    break;
                }
            }
        }
    }
    return check;
}

void PrintArray(int[,,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToPrint.GetLength(2); k++)
            {
                Console.Write($" {arrayToPrint[i, j, k]} ({i} {j} {k})");
            }
            Console.WriteLine();
        }
    }
}

int[,,] CreateArray(int dimention1, int dimention2, int dimention3, int leftRange, int rightRange)
{
    int[,,] array = new int[dimention1, dimention2, dimention3];
    for (int i = 0; i < dimention1; i++)
    {
        for (int j = 0; j < dimention2; j++)
        {
            for (int k = 0; k < dimention3; k++)
            {
                bool check;
                int element;
                do
                {
                    element = new Random().Next(leftRange, rightRange);
                    check = CheckDoubleElement(array, element);
                } while (check);
                
                array[i, j, k] = element;                
            }
        }
    }
    return array;
}

int dimention1 = 2;
int dimention2 = 2;
int dimention3 = 2;
int leftRange = 1;
int rightRange = 10;
int[,,] matrix = CreateArray(dimention1, dimention2, dimention3, leftRange, rightRange);

PrintArray(matrix);
