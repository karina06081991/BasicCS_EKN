﻿//Дано число. Проверить кратно ли оно 7 и 23

/*bool b;
b=true;
b=false;
b=2*2>5;
int x=150;
b=x%7==0;
Console.WriteLine(b);*/

bool b,c,d;
int x=7*23;
b=x%7==0;
c=x%23==0;
d=b && c;
/*System.Console.WriteLine(x);
System.Console.WriteLine(b);
System.Console.WriteLine(c);
System.Console.WriteLine(d);*/

System.Console.WriteLine(x%7==0 && x%23==0);
if (d)
{
    System.Console.WriteLine($"{x} кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"{x} кратно 7 и 23");
}