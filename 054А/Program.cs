// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] a;
a=Init(3,4);
Print(a);

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1)-1;j++) 
    {
        for(int z=0;z<a.GetLength(1)-1;z++)
        {
            if (a[i,z]<a[i,z+1])
            {
            int temp=0;
            temp=a[i,z];
            a[i,z]=a[i,z+1];
            a[i,z+1]=temp;
            }
        }
    }
}
System.Console.WriteLine();

Print(a);

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
