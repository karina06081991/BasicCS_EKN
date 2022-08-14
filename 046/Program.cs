// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1


int N=int.Parse(Console.ReadLine());
int[] a=new int[N];
a[0]=0;
a[1]=1;
    
for(int i=2;i<a.Length;i++)
    a[i]=a[i-1]+a[i-2];

for(int i=2;i<a.Length;i++)
    System.Console.WriteLine($"{a[i],4}");


