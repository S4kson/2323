using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[20];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToString(random.Next(-100, 100));
                Console.WriteLine(array[i]);
            }
            string s11 = string.Join("\n", array);
            File.WriteAllText(@"C:\Users\sakso\Desktop\laba5\З2\вывод.txt", s11);
            string txt = "";


            int a = 20;
            using (StreamWriter sw = new StreamWriter(@"C:\Users\sakso\Desktop\laba5\З2\вывод.txt", false))
            {  
                for (int i = 0; i < a; i++)
                {
                    int array   
                   
                    if (min > arr[i])
                    {
                        min = arr[i];
                    }
                }
                Console.WriteLine("\n min={0}", min);


            }
            }   Console.ReadKey();

        }
    }
        
}
