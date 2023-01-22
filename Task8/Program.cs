// Определить, присутствует ли в заданном массиве, некоторое число

int[] new_array(int number) // функция задаёт массив с заданным кол-м случайных значений.
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(1, 100); 
    }
    return array;
}

Console.Write("Укажите число элементов для нового массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Укажите число, которое нужно найти в массиве: ");
int x = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new_array(n);
Console.WriteLine("Посмотрим сгенерированный массив:");
foreach (int el in arr) 
{
    Console.Write(el + " ");
}

int check = 0;
foreach (int element in arr) 
{
    if (element == x) 
    {
        Console.WriteLine($"Число {x} присутствует в заданном массиве");
        check = 1;
        break;
    }
}
if (check == 0) Console.WriteLine($"Число {x} отсутствует в заданном массиве");
