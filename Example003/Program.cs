/* ДЗ 4
Задача 3: Напишите программу, которая задаёт массив из
8 элементов случайными числами и выводит их на экран.
Оформите заполнение массива и вывод в виде функции
(пригодится в следующих задачах)
1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8
6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1
*/

int[] RendArrNum(int quantity, int MinNumber, int MaxNumber) // Запись случайных чисел от Min до Max в массив определённой длины. Max входит в диапазон.
{
    int[] arrey = new int[quantity];

    for (int i = 0; i < quantity; i++)
    {
        arrey[i]=new Random().Next(MinNumber,MaxNumber-1);
    }
    return arrey;

}

void PrintArr(int[] array) // Вывод массива в консоль в виде [66,1,19,73,48,13,50,25]
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < (array.Length - 1)) Console.Write(array[i] + ",");
        if (i == (array.Length - 1)) Console.WriteLine(array[i] + "]");
    }
}

 
PrintArr(RendArrNum(8,0,99));