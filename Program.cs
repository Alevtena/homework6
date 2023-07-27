// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int[] CreateArray (int size)
{
    int[] array = new int[size];
    for (int i =0; i<size; i++)
    {
        Console.Write($"Введите элемент массива {i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int Count (int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
        if( array[i]>0) count +=1;
    return count;
}      
Console.Write("Input a size of array" + " ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myarray  = CreateArray(n);
ShowArray(myarray);
Console.Write($" Количество элементов больше 0 - {Count(myarray)}");