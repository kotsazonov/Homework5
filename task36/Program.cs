// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = RandomArray();
int[] arrayProduct = ArrayProduct(array);

PrintArray(array);
PrintArray(arrayProduct);

int[] ArrayProduct(int[] array)
{
    int[] arrayProduct = new int[(array.Length / 2) + 1];

    for(int i = 0; i < (array.Length / 2) + 1; i++)
    {
        if(i == (array.Length / 2))
            arrayProduct[i] = array[i];
        else
            arrayProduct[i] = array[i] * array[(array.Length - 1) - i];
    }
        
    return arrayProduct;
}

int[] RandomArray()
{
    int[] array = new int[5];
    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(-10, 11);

    return array;
}

void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write($"{element} ");

    Console.WriteLine();
}
