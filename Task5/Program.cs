// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int product = 1;
for (int i = 1; i <= n; i++)
{
    product = product * i;
    //Console.WriteLine(i + " " + product);
}
Console.WriteLine("произведения чисел от 1 до " + n + " равно " + product);
