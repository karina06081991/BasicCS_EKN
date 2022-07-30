// Задать массив из 8 элементов и вывести их на экран

int[] t;
Init(out t,8,0,10);
Print(t);

   void Init(out int[] t, int Length,int min,int max)
   {
      t=new int[Length];
      Random random=new Random();
      for(int i=0;i<t.Length;i++)
       t[i]=random.Next(min,max+1);
   }

   void Print(int[] t)
   {
      for(int i=0;i<t.Length;i++)
      System.Console.Write($"a[{i}]={t[i]} ");
   }