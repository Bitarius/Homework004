/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

//метод получения числа с консоли
int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

//метод, который считает степень
int Exponent(int numberOne, int numberTwo)
{
    int exponent = 1;

    for (int i = 1; i <= numberTwo; i++)
    {
        exponent = exponent * numberOne;
    }

    return exponent;
}

int numberOne = GetNumber("Введите число: ");
int numberTwo = GetNumber("Укажите степень: ");

int result = Exponent(numberOne, numberTwo);
Console.WriteLine($"Результат: {result}");