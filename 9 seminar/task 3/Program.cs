int m = InputNumbers("Enter m: ");
int n = InputNumbers("Enter n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Functoin of akerman = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
