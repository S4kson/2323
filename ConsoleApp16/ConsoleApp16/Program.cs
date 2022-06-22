int S = 0;
int SS=0;
double [] mas = new double [30];
int N;
N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < N; i++)
{
    Random r = new Random();
    int c =r.Next(10, 999);
    mas[i] = c;
}
for (int i = 0; i < 30; i++)
{
    double a = mas[i] / 100;
    double b = mas[i] - (100*a)/10;
    double c = mas[i] - (100 * a + 10 * b) / 1;
    double m = a + b + c;
    if (a>0)
    {
        if (m == N)
        {
            S = S + 1;
        }
            
    }
    else
    {
        double h = (b*b+c*c)%13;
        if (h == 0)
        {
            SS = SS + 1;
        }
    }
}
Console.WriteLine("S="+ S);
Console.WriteLine("SS="+ SS);
