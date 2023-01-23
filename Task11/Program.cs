// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] new_array(int number) // функция задаёт массив с заданным кол-м случайных значений.
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 100); 
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

void NegSumCount(int[] array) // функция показывает сумму чисел одномерного массива стоящих на нечетной позиции.
{  
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum = sum + array[i];
    }
    Console.WriteLine($"Сумма чисел одномерного массива стоящих на нечетной позиции = {sum}");
}
//////////////

Console.Write("Укажите число элементов для нового массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new_array(n);
Console.WriteLine("Посмотрим сгенерированный массив:");
PrintArr(arr);
NegSumCount(arr);
