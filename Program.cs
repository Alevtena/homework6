// Task 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

/* int[] CreateArray (int size)
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
Console.Write($" Количество элементов больше 0 - {Count(myarray)}"); */

// Task 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] XYCoordinata(int k1, int b1, int k2, int b2)
{
    double[] array = new double[2];
    double a = b2-b1;
    double b = k1-k2; 
    array[0] = a/b;
    array [1]= k1*array[0]+b1;
    return array;
}

void  Proverka (int k1, int b1, int k2, int b2)
{
    if (k1 !=k2 && b1 !=b2) 
    {
        double[] myarray = XYCoordinata(k1,b1,k2,b2);
        Console.Write ($"Точка пересечения c координатами: ");
    }  
    else 
    {
        if (k1 == k2 &&  b1 == b2) Console.Write ("Прямые совпадают");
        if (k1==k2 && b1 !=b2) Console.Write("Прямые параллельны, точек пересечения нет");
    }
}
void ShowArray(double[] array)
{
    for(int i=0;i<2; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write ("Input k1" +" ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input b1" +" ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input k2" +" ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input b2" +" ");
int b2 = Convert.ToInt32(Console.ReadLine());

Proverka(k1,b1,k2,b2);
double[] myarray = XYCoordinata(k1,b1,k2,b2);
ShowArray(myarray);