// Найти кубы чисел от 1 до N

Console.Write("Чтобы получить кубы чисел от 1 до N ведите число N : ");
int n = int.Parse(Console.ReadLine() ?? "0");

for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i + " " + i * i * i);
}
