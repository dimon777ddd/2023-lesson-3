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
    int minSumLine = 0;
int sumLine = SumLineElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(matrix, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;

  }
}  
}
    int SumLineElements(int[,] matrix, int i)
{
  int sumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumLine += matrix[i,j];
  }
  return sumLine;
}
    
    

const int ROWS = 3;
const int COLUMNS = 4;
const int LEFTRANGE = 0;
const int RIRHTRANGE = 10;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIRHTRANGE);
PrintMatrix(array);
Console.WriteLine();






