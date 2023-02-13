//Написать программу возведения числа А в целую стень B
Console.Write("Enter number a: ");
int a = int.Parse(Console.ReadLine() ?? "");
Console.Write("Enter exponentiation n: ");
int n = int.Parse(Console.ReadLine() ?? "");
int PowerNumber(int a, int n)
{if (n == 0) return 1;
else if (n % 2 == 0) return PowerNumber(a * a, n / 2);
else return PowerNumber(a, n-1) * a;}
Console.WriteLine(PowerNumber(a, n));