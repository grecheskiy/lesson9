//Найти сумму элементов от M до N, N и M заданы
Console.Write("Enter min number M: ");
int M = int.Parse(Console.ReadLine() ?? "");
Console.Write("Enter max number N: ");
int N = int.Parse(Console.ReadLine() ?? "");
int Numbers(int M, int N)
{if (N == 0) return 0;
else return N + Numbers(M,N-1); }
Console.WriteLine(Numbers(M,N));