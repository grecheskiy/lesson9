//Написать программу показывающие первые N чисел, 
//для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем
Console.Write("Enter x: ");
int x = int.Parse(Console.ReadLine() ?? "");
Console.Write("Enter y: ");
int y = int.Parse(Console.ReadLine() ?? "");
int N = 10;
int Metod(int a, int b, int n)
{
if (n == 1) return a;
if (n == 2) return b;
return Metod(a, b, n - 1) + Metod(a, b, n - 2);
}
for (int i = 1; i < N; i++)
{
Console.Write(Metod(x, y, i) + " ");
}
Console.WriteLine();