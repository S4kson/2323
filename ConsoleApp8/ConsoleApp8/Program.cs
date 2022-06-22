using System;
class Program
{
    static float sqr(float n)
    {
        if (n > 1) { return sqr(n - 1) + 2 * (n - 1) + 1; }
        return 1;
    }
    public static void Main(string[] args)
    {
        for (int i = 1; i < 25; i++)
        {
            Console.WriteLine($"n={i} => n^2={sqr(i)}");
        }
    }
}

