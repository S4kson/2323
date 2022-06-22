using System;
namespace ConsoleApp2
{
    class Hexadec2
    {
        public int cc;
        public double cd;
        public Hexadec2 GetInfo()
        {
            Console.WriteLine("Введите целую часть числа в шестнадцатиричной системе счисления.Вводите по 1 символу в строку.Когда запишите целую часть числа, введите End.");
           
            string n = Console.ReadLine();
            Hexadec2 num = new Hexadec2();
            num.cc = 0;
            if (n == "F")
                num.cc = +15;
            else if (n == "E")
                num.cc = +14;
            else if (n == "D")
                num.cc = +13;
            else if (n == "C")
                num.cc = +12;
            else if (n == "B")
                num.cc = +11;
            else if (n == "A")
                num.cc = +10;
            else if (n == "9")
                num.cc = +9;
            else if (n == "8")
                num.cc = +8;
            else if (n == "7")
                num.cc = +7;
            else if (n == "6")
                num.cc = +6;
            else if (n == "5")
                num.cc = +5;
            else if (n == "4")
                num.cc = +4;
            else if (n == "3")
                num.cc = +3;
            else if (n == "2")
                num.cc = +2;
            else if (n == "1")
                num.cc = +1;
            else if (n == "0")
                num.cc = +0;
            while (n != "End")
            {
                n = Console.ReadLine();
                if (n == "F")
                    num.cc = num.cc * 16 + 15;
                else if (n == "E")
                    num.cc = num.cc * 16 + 14;
                else if (n == "D")
                    num.cc = num.cc * 16 + 13;
                else if (n == "C")
                    num.cc = num.cc * 16 + 12;
                else if (n == "B")
                    num.cc = num.cc * 16 + 11;
                else if (n == "A")
                    num.cc = num.cc * 16 + 10;
                else if (n == "9")
                    num.cc = num.cc * 16 + 9;
                else if (n == "8")
                    num.cc = num.cc * 16 + 8;
                else if (n == "7")
                    num.cc = num.cc * 16 + 7;
                else if (n == "6")
                    num.cc = num.cc * 16 + 6;
                else if (n == "5")
                    num.cc = num.cc * 16 + 5;
                else if (n == "4")
                    num.cc = num.cc * 16 + 4;
                else if (n == "3")
                    num.cc = num.cc * 16 + 3;
                else if (n == "2")
                    num.cc = num.cc * 16 + 2;
                else if (n == "1")
                    num.cc = num.cc * 16 + 1;
                else if (n == "0")
                    num.cc = num.cc * 16 + 0;
            }
            Console.WriteLine("Введите дробную часть числа в шестнадцатиричной системе счисления.Вводите по 1 символу в строку.Когда запишите дробную часть числа, введите End.");
           
            n = Console.ReadLine();
            int b = 16;
            num.cd = 0;
            if (n == "F")
                num.cd = +(15.0 / 16);
            else if (n == "E")
                num.cd = +(14.0 / 16);
            else if (n == "D")
                num.cd = +(13.0 / 16);
            else if (n == "C")
                num.cd = +(12.0 / 16);
            else if (n == "B")
                num.cd = +(11.0 / 16);
            else if (n == "A")
                num.cd = +(10.0 / 16);
            else if (n == "9")
                num.cd = +(9.0 / 16);
            else if (n == "8")
                num.cd = +(8.0 / 16);
            else if (n == "7")
                num.cd = +(7.0 / 16);
            else if (n == "6")
                num.cd = +(6.0 / 16);
            else if (n == "5")
                num.cd = +(5.0 / 16);
            else if (n == "4")
                num.cd = +(4.0 / 16);
            else if (n == "3")
                num.cd = +(3.0 / 16);
            else if (n == "2")
                num.cd = +(2.0 / 16);
            else if (n == "1")
                num.cd = +(1.0 / 16);
            else if (n == "0")
                num.cd = +0;
            while (n != "End")
            {
                n = Console.ReadLine();
                b = b * 16;
                if (n == "F")
                    num.cd = num.cd + (15.0 / b);
                else if (n == "E")
                    num.cd = num.cd + (14.0 / b);
                else if (n == "D")
                    num.cd = num.cd + (13.0 / b);
                else if (n == "C")
                    num.cd = num.cd + (12.0 / b);
                else if (n == "B")
                    num.cd = num.cd + (11.0 / b);
                else if (n == "A")
                    num.cd = num.cd + (10.0 / b);
                else if (n == "9")
                    num.cd = num.cd + (9.0 / b);
                else if (n == "8")
                    num.cd = num.cd + (8.0 / b);
                else if (n == "7")
                    num.cd = num.cd + (7.0 / b);
                else if (n == "6")
                    num.cd = num.cd + (6.0 / b);
                else if (n == "5")
                    num.cd = num.cd + (5.0 / b);
                else if (n == "4")
                    num.cd = num.cd + (4.0 / b);
                else if (n == "3")
                    num.cd = num.cd + (3.0 / b);
                else if (n == "2")
                    num.cd = num.cd + (2.0 / b);
                else if (n == "1")
                    num.cd = num.cd + (1.0 / b);
                else if (n == "0")
                    num.cd = num.cd + 0;
            }
            return num;
        }
        public void Print(Hexadec2 num)
        {
            int c = num.cc, k = 0, t = 0, p;
            double d = num.cd;
            Console.Write("Число: ");
            if (num.cc == 0)
                Console.Write("0");
            while (c != 0)
            {
                c = c / 16;
                k++;
            }
            int[] mc = new int[k];
            c = num.cc;
            for (int i = k - 1; i >= 0; i--)
            {
                mc[i] = c % 16;
                c = c / 16;
            }
            for (int i = 0; i < k; i++)
            {
                if (mc[i] == 15)
                    Console.Write("F");
                else if (mc[i] == 14)
                    Console.Write("E");
                else if (mc[i] == 13)
                    Console.Write("D");
                else if (mc[i] == 12)
                    Console.Write("C");
                else if (mc[i] == 11)
                    Console.Write("B");
                else if (mc[i] == 10)
                    Console.Write("A");
                else
                    Console.Write(mc[i]);
            }
            Console.Write(".");
            if (num.cd == 0)
                Console.Write("0");
            while (d != 0)
            {
                if (t > 10)
                    break;
                p = Convert.ToInt32(d * 16);
                d = d * 16;
                if (p == 16)
                    p--;
                if (d > 1)
                {
                    if (p == 15)
                        Console.Write("F");
                    else if (p == 14)
                        Console.Write("E");
                    else if (p == 13)
                        Console.Write("D");
                    else if (p == 12)
                        Console.Write("C");
                    else if (p == 11)
                        Console.Write("B");
                    else if (p == 10)
                        Console.Write("A");
                    else
                        Console.Write(p);
                }
                if (p > d)
                    p--;
                d = d - p;
                t++;
            }
            Console.WriteLine();
        }
        public Hexadec2 Raz(Hexadec2 num1, Hexadec2 num2)
        {
            int d;
            Hexadec2 numr = new Hexadec2();
            double n1 = num1.cc + num1.cd;
            double n2 = num2.cc + num2.cd;
            numr.cc = Convert.ToInt32(n1 - n2);
            if (numr.cc > n1 - n2)
                numr.cc = numr.cc - 1;
            d = Convert.ToInt32(n1 - n2);
            if (d > n1 - n2)
                d--;
            numr.cd = (n1 - n2) - d;
            return numr;
        }
        public Hexadec2 Del(Hexadec2 num1, Hexadec2 num2)
        {
            int d;
            Hexadec2 numr = new Hexadec2();
            double n1 = num1.cc + num1.cd;
            double n2 = num2.cc + num2.cd;
            numr.cc = Convert.ToInt32(n1 / n2);
            if (numr.cc > n1 / n2)
                numr.cc = numr.cc - 1;
            d = Convert.ToInt32(n1 / n2);
            if (d > n1 / n2)
                d--;
            numr.cd = (n1 / n2) - d;
            return numr;
        }
    }
    class Program
    {
        static void Main()
        {
            int c;
            Hexadec2 num1 = new Hexadec2(), num2 = new Hexadec2(), numr = new Hexadec2();
            num1 = num1.GetInfo();
            num2 = num2.GetInfo();
            numr = numr.Raz(num1, num2);
            numr.Print(numr);
            numr = numr.Del(num1, num2);
            numr.Print(numr);
            Console.ReadLine();
        }
    }
}