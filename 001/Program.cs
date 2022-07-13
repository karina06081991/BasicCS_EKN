//С клавиатуры вводится целое число. Вывести квадрат числа

double a;
double b;
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
b=a*a;
Console.WriteLine($"{a}^2={b}");


/*string? s;
s=Console.ReadLine();
System.Console.WriteLine(s);*/