// Найти сумму чисел от 1 до А

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int sum = 0;
for (int i = 1; i <= n; i++)
{
    sum = sum + i;
    // Console.WriteLine(i + " " + sum);
}
Console.WriteLine("Сумма чисел от 1 до " + n + " равна " + sum);
