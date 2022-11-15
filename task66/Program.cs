Console.WriteLine("Задайте значения M: ");
int m = InputNumber();
Console.WriteLine("Задайте значения N: ");
int n = InputNumber();

Console.Write(SumNumbers(m, n));

int InputNumber()
{
  int n = int.Parse(Console.ReadLine());
  return n;
}

int SumNumbers(int m, int n)
{
  if (m != n) return n + SumNumbers(m, n - 1);
  else return m;
}
Console.WriteLine();
