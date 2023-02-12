//Показать натуральные числа от M до N, N и M заданы
Console.Write("Enter min number M: ");
int M = int.Parse(Console.ReadLine() ?? "");
Console.Write("Enter max number N: ");
int N = int.Parse(Console.ReadLine() ?? "");
string Numbers(int M, int N)
{if (M <= N) return $"{M} " + Numbers(M+1,N); 
else return string.Empty;}
Console.WriteLine(Numbers(M,N));