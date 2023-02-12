//Показать натуральные числа от N до 1, N задано
Console.Write("Enter number N: ");
int N = int.Parse(Console.ReadLine() ?? "");
int a = 1;
string Numbers(int a, int N)
{if (a <= N) return Numbers(a+1,N) + $"{a} "; 
else return string.Empty;}
Console.WriteLine(Numbers(a,N));