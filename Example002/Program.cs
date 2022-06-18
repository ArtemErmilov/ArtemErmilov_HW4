/*ДЗ 4
Задача 2: 
Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int SepNambToSum(int number) // Функция разделения числа на символы (числа) и сложение их
{
    int length = number.ToString().Length;
    int result = 0;
    int a = 0;

    for (int i = 0; i < length; i++)
    {
        a = number % 10;
        number = number / 10;
        result += a;
    }
    return result;
}

int Prompt(string message) // Ввод числа ( функция )
{
    Console.Write(message);
    string a_String = Console.ReadLine();
    return int.Parse(a_String);
}


int number= Prompt("Ввведите число => ");

Console.WriteLine($"Сумма чисел в числе {number} равняется {SepNambToSum(number)}");

