// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] new_array(int number) // функция задаёт массив с заданным кол-м случайных значений.
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(100, 1000); 
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

void PosNegCount(int[] array) // функция показывает количество нечетных\четных чисел.
{  
    int PosCount = 0;
    int NegCount = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0) PosCount++;
        else NegCount++;
    }
    Console.WriteLine($"В массиве {PosCount} чётных чисел и {NegCount} нечётных");
}
//////////////

Console.Write("Укажите число элементов для нового массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new_array(n);
Console.WriteLine("Посмотрим сгенерированный массив:");
PrintArr(arr);
PosNegCount(arr);
