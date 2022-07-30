// Выяснить, являются ли три числа стронами треугольника

double a=2,b=4,c=3;
System.Console.WriteLine(IsTreangle(a,b,c));

bool IsTreangle(double a, double b, double c)
{
    return (a+b>c && b+c>a && a+c>b);
}

