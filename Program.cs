// Задача 1
// Найти максимальный и минимальный элемент массива
// и вывести их на экран
// [1,19, 10, 3, 0, 10]
// Размер массива 15 
// Значения = рандом в пределах от 0 до 100

// int size = 15;
// int[]array = new int[size];
// FillArray (array);
// System.Console.WriteLine("[{0}]" , string.Join(" , ", array));
// int min , max ;
// MaxMin(array , out min , out max);
// System.Console.WriteLine($"Max = {max} ; Min = {min}");

// void FillArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//     array[i] = new Random().Next(0 , 100);
//     }
// }

// void MaxMin(int [] array , out int min , out int max)
// {
//      max = array[0];
//      min = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         max = array[i];
//         if (array[i] < min)
//         min = array[i];
//     }
// }
// End


// Задача 2 
// Проверить является ли массив отсортированным
// [0,1,3,10,10,19] - > да
// [0,1,3,10,20,19] - > нет

int[] array = {0,1,30,10,10,19};
System.Console.WriteLine("[{0}]" , string.Join(" , ", array));
if (!CheckSort(array) ) // ! -не
    System.Console.WriteLine("No");
else
    System.Console.WriteLine("Yes");

bool CheckSort (int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > array[i+1])
        return false;
    }
    return true;
}


// Задача 3
// Является ли массив арифметической прогрессией
// 1 {1,3,5,7,9} - да



