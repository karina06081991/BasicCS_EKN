// Программа проверяет пятизначное число на палиндромом


int a=97578;
int a1=a/10000;
int a2=a/1000%10;
int a3=a%100/10;
int a4=a%10;

if(a1==a4 & a2==a3)
{
    System.Console.WriteLine("число является палиндромом");
}
else
{
    System.Console.WriteLine("число не является палиндромом");
}