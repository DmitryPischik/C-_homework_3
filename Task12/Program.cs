// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] new_array(int number) // функция задаёт массив с заданным кол-м случайных значений.
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100); 
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

void productOfPare(int[] array) // функция находит произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д..
{      
    for (int i = 0; i < array.Length / 2; i++)
    {
        Console.Write(array[i] * array[array.Length - 1 - i] + " ");
    }    
}
//////////////

Console.Write("Укажите число элементов для нового массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new_array(n);
Console.WriteLine("Посмотрим сгенерированный массив:");
PrintArr(arr);
productOfPare(arr);

