/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
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

//Метод подсчета суммы цифр
int GetSumm(int number)
{
    
    int summ = 0;
    while (number > 0)
    {
        int digit = number % 10;
        summ = summ + digit ;
        number = number / 10;
    }
    return summ;
}


int number = GetNumber("Введите число: ");
int getSumm = GetSumm(number);
Console.WriteLine($"Сумма цифр = {getSumm}");