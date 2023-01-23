// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] new_array() // функция задаёт массив из 123 целых чисел.
{
    int[] array = new int[123];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 300); 
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

void CheckTwoArr(int[] array) // функция считает количество элементов массива из отрезка [10,99].
{
    int count = 0;
    foreach (int item in array)
    {
        if ((item >10 && item < 99)) {count++;}
    }
    Console.WriteLine(count);
}
////////////////////////////

int[] arr = new_array();
PrintArr(arr);
CheckTwoArr(arr);
