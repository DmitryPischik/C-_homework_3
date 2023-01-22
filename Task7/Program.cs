// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] new_array() // функция задаёт массив из 8 элементов, заполненных нулями и единицами.
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 2); 
    }
    return array;
}

int[] arr = new_array();
Console.WriteLine("Выведем на экран сгенерированный массив:");
foreach (int el in arr) 
{
    Console.Write(el + " ");
}
