int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];

    for(int i = 0; i < matrix.GetLength(0); i++) 
    {
         for(int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++) 
    {
         for(int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Change(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        if (matrix[i, k] < matrix[i, k + 1])
        {
          int temp = matrix[i, k + 1];
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = temp;
        }
      }
    }
  }
}

const int ROWS = 3;
const int COLUMNS = 4;
const int LEFTRANGE = 0;
const int RIRHTRANGE = 10;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIRHTRANGE);
PrintMatrix(array);
Console.WriteLine();
Change(array);
PrintMatrix(array);


