// Возведите число А в натуральную степень B используя цикл

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите натуральное число В: ");
int B = int.Parse(Console.ReadLine() ?? "0");

int result = 1;
for (int i = 1; i <= B; i++)
{
    result = A * result;
}
Console.WriteLine(A + " в степени " + B + " равно " + result);
