// Подсчитать сумму цифр в числе

Console.Write("Введите целое число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int count = 0;

while (n != 0)
{
    n = n / 10;
    count++;
}
Console.WriteLine("Введённом числе " + count + " цифр");