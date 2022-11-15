Main();

void Main()
{
    Console.Write("Введите число M: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write(A(m, n));
}

int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return A(m - 1, 1);
    return A(m - 1, A(m, n - 1));
}