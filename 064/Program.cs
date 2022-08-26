// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

string P(int M, int N)
{
    if (M==N) return ($"{M}");
    else return M +" "+ P(M+1, N);
}
System.Console.WriteLine(P(5,10));