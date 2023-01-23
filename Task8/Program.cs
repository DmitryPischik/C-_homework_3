// Определить, присутствует ли в заданном массиве, некоторое число

int[] new_array(int number) // функция задаёт массив с заданным кол-м случайных значений.
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(1, 10); 
    }
    return array;
}
void PrintArr(int[] array) // функция просматривает массив целых часел.
{  
    foreach (int item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
void checkArray(int[] array, int number) // функция проверяет присутствует ли целое число в массиве целых часел.
{
int check = 0;
foreach (int element in array) 
{
    if (element == number) 
    {
        Console.WriteLine($"Число {number} присутствует в заданном массиве");
        check = 1;
        break;
    }
}
if (check == 0) Console.WriteLine($"Число {number} отсутствует в заданном массиве");
}

Console.Write("Укажите число элементов для нового массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Укажите число, которое нужно найти в массиве: ");
int x = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new_array(n);
Console.WriteLine("Посмотрим сгенерированный массив:");
PrintArr(arr);
checkArray(arr, x);
