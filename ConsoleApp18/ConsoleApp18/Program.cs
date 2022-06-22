using System.Security.Cryptography;
class Program
{
    public static byte RND()
    {
        RNGCryptoServiceProvider Rand = new RNGCryptoServiceProvider();
        byte[] randomNumber = new byte[1];
        Rand.GetBytes(randomNumber);
        return (randomNumber[0]);
    }

    static void Main(string[] args)
    {

        for (int i = 0; i < 100; i++)
        {
            double R = RND();
            Console.Write(R);
            Console.Write(" ");
        }
        Console.ReadLine();

    }
}