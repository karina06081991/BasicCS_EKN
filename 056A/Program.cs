// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей
// суммой элементов. Программа считает сумму элементов в каждой строке и выдает номер строки с наименьшей суммой элементов.

int[,] a;
a=Init(5,3);
Print(a);
int minsum=100;

int indexLinemin=0;

for(int i=0;i<a.GetLength(0);i++)
{
    int sum=0;
    for(int j=0;j<a.GetLength(1);j++) 
    {
        sum=sum+a[i,j];
    }
    if(sum<minsum)
    {
        minsum=sum;
        indexLinemin=i;
    }
    
}
System.Console.WriteLine($"{indexLinemin+1} ");

void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j],4} ");
            System.Console.WriteLine();
    }
}

int[,] Init(int N, int M)
{
    a=new int[N,M];
    Random random=new Random();

    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            a[i,j]=random.Next(1,11);
        }
    }
    return a;
}
