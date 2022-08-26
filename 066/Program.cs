// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N


int P(int M, int N)
{
    if (M==N) return M;
    else return P(M+1,N) + M;
}
System.Console.WriteLine(P(1,5));