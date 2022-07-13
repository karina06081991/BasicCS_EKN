// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести на экран остаток от деления a на b

int a,b;
int c;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
c=a%b;
if(a%b==0)
{
    System.Console.WriteLine("Число a кратно числу b");
}

else
{
    Console.WriteLine("Остаток деления a на b");
    System.Console.WriteLine($"{c}");
}

