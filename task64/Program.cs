void Main()
{
    Console.WriteLine("Введите число N");
    int n = int.Parse(Console.ReadLine()!);
 GetNumbers(n);
}

void GetNumbers(int n)
{
    if (n <= 1) return;
    else
    {
        if (n % 2 == 0) {Console.Write($" {n}");
        GetNumbers(n - 2);}
        else
        {
            n--;
            Console.Write($" {n}");
            GetNumbers(n - 2);
        }

    }
}

Main();
