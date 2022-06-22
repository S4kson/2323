Random rand = new Random();
int i = rand.Next(10);
int count = 1;
Console.WriteLine("Компьютер загадал число от 0 до 9. Попробуйте отгодать его за три попытки.");
Console.WriteLine("Введите первое число:");
int k = Convert.ToInt32(Console.ReadLine());
while (count <= 3)
{
    if (i > k)
    {
        Console.WriteLine("Нет, это не число " + k + "! Загаданное число больше. Попытка № " + count + ":");

        k = Convert.ToInt32(Console.ReadLine());
    }
    if (i < k)
    {
        Console.WriteLine("Нет, это не число " + k + "! Загаданное число меньше. Попытка № " + count + ":");

        k = Convert.ToInt32(Console.ReadLine());
    }
    if (i == k)
    {
        Console.WriteLine("Да! Компьютер загадал число " + k + "!");
        break;
    }
   
    else
    {
        count++;
        if (count == 3)
        {
            Console.WriteLine("Увы, вы не отгодали загаданное число. Это было число " + i + "!");
            break;
        }
    }
   
}
Console.ReadLine();