/*ДЗ 4
Задача 1: 
Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int NumberPow(int number, int pow )
{
    int result=number;
    for ( int i = 1; i < pow; i++)
    {
        result *=number;
    }
    return result;
}

int Prompt(string message) // Ввод числа ( функция )
{
    Console.Write(message);
    string a_String = Console.ReadLine();
    return  int.Parse(a_String);
}

int number = Prompt("Введите число => ");
int power  = Prompt("Введите степень числа => ");

Console.WriteLine($" Число {number} в степени {power} равняется {NumberPow(number,power)} ");




