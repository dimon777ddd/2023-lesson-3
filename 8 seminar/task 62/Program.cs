int n = 4;
int[,] squarematrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= squarematrix.GetLength(0) * squarematrix.GetLength(1))
{
  squarematrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < squarematrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= squarematrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > squarematrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(squarematrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
