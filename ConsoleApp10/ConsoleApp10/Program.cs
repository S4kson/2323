using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace laba5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = "";
            try
            {
                StreamReader r = new StreamReader("laba5.txt");
                txt = r.ReadToEnd();
                r.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Чтение прошло успешно!");
            }

            int[] alph = new int[32];
            for (int i = 0; i < 32; i++)
            {
                alph[i] = 0;
            }
            for (int i = 0; i < txt.Length; i++)
            {
                if ((int)txt[i] >= 1072 && (int)txt[i] <= 1103)
                {
                    alph[((int)txt[i]) - 1072]++;
                }
                else if ((int)txt[i] >= 1040 && (int)txt[i] <= 1071)
                {
                    alph[(int)txt[i] - 1040]++;
                }
            }
            for (int i = 0; i < 32; i++)
            {
                Console.WriteLine($"{(char)(i + 1072)} - {alph[i]}");
            }
            Console.ReadKey();

        }
    }
}

}
