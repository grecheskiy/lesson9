//Найти сумму цифр числа
Console.Write("Enter number 1 to 99: ");
int number = int.Parse(Console.ReadLine() ?? "");
int SumNumber(int number)
{if (number < 0 || number >= 100 )
return 0;
else return (number / 10) + (number % 10);
}Console.WriteLine(SumNumber(number));