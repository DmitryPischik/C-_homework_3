// Показать кубы чисел, заканчивающихся на четную цифру

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

int[] arr = new_array(n);
Console.WriteLine("Посмотрим сгенерированный массив:");
foreach (int el in arr) 
{
    Console.Write(el + " ");
}
Console.WriteLine();
Console.WriteLine("Покажем кубы чисел, заканчивающихся на четную цифру:");
// Если чисело, заканчивается на четную цифру, то это чётное число
// Поэтому найдём чётные числа в массиве и возведём их в куб.
foreach (int el in arr)
{
    if (el % 2 == 0) Console.WriteLine(el * el * el);
}
