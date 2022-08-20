// Даны две квадратные таблицы чисел. Требуется построить третью, каждый элемент которой равен сумме элементов, стоящих
// на том же месте в 1-й и 2-й таблицах. Входные данные
// Во входном файле записано сначала число N, затем записана первая таблица, а после нее - вторая. 
// Элементы таблиц - числа от 0 до 100. 100>=N>=1.


int N=3;
int [,] a;
int [,] b;
int [,] c;
a=InitA(N,N);
b=InitA(N,N);
c=InitA(N,N);
System.Console.WriteLine("Таблица 1");
Print(a);
System.Console.WriteLine("Таблица 2");
Print(b);
Sum(a,b);
System.Console.WriteLine("Таблицы 3: сумма таблиц 1 и 2");
Print(c);

void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j],5} ");
        System.Console.WriteLine();
    }
}

int[,] InitA(int N,int M)
{
    a=new int[N,M];

    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++) 
        {
            a[i,j]=random.Next(1,100);
        }
    }
    return a;
}

void Sum(int[,] a, int[,] b)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++) 
        c[i,j] = a[i,j] + b[i,j];
    }
}