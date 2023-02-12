//Показать натуральные числа от 1 до N, N задано
Console.Write("Enter number N: ");
int N = int.Parse(Console.ReadLine() ?? "");
int a = 1;
string Numbers(int a, int N)
{if (a <= N) return $"{a} " + Numbers(a+1,N); 
else return string.Empty;}
Console.WriteLine(Numbers(a,N));