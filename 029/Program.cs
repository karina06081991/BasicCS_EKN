// Подсчитать сумму цифр в числе

int num, sum = 0, r;
System.Console.WriteLine("Введите число : ");
num = int.Parse(Console.ReadLine());

while(num != 0)
{
    r=num%10;
    num=num/10;
    sum=sum+r;
}

System.Console.WriteLine($"{sum}");