int Lenght = int.Parse(Console.ReadLine());
Console.WriteLine();
int[] Array1 = new int[Lenght];
Random r = new();

for (int i = 0; i < Lenght; i++)
{
    Array1[i] = r.Next(-100, 100);
    Console.WriteLine(Array1[i]);
}

Console.WriteLine();

for (int i = Array1.Length - 1; i > 0; i--)
{
    int rand = r.Next(i);

    int temp1 = Array1[rand];
    Array1[rand] = Array1[i];
    Array1[i] = temp1;
}
for (int i = 0; i < Lenght; i++)
{
    Console.WriteLine(Array1[i]);
}