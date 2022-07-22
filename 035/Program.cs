// Написать программу замены элементов массива на противоположные


int N=12;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(1,11);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");

int[] b=new int[a.Length];
for(int i=0;i<a.Length;i++)
    b[i]=a[i]*-1;
System.Console.WriteLine();
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{b[i],4}");
