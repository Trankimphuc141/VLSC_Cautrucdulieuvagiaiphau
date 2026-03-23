using System;

class Program 
{
    static long GiaiThua(int n)
{
    // Trường hợp cơ sở
    if (n <= 1) return 1;

    // Gọi đệ quy
    return n * GiaiThua(n - 1);
}

static int Fibonacci(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    return Fibonacci(n - 1) + Fibonacci( n - 2);
}


static void Main(string[] args)
{
    Console.Write("Nhap so n: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("{0}! = {1}", n, GiaiThua(n));
}
}