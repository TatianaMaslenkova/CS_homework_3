Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int number = Math.Abs(int.Parse(Console.ReadLine()!));
int digit1 = number / 10000;
int digit2 = number / 1000 % 10;
int digit4 = number / 10 % 10;
int digit5 = number % 10;
if ((number > 9999) && (number < 100000))
{
    if ((digit1 == digit5) && (digit2 == digit4))
    {
        Console.WriteLine("Введенное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Введенное число НЕ является палиндромом");
    }
}
else
{
    Console.WriteLine("Нужно ввести пятизначное число!");
}

// Второй вариант:
// Console.Clear();

// Console.WriteLine("Введите пятизначное число: ");

// int number = int.Parse(Console.ReadLine()!);
// string numberstr = Convert.ToString(number);
// int length = numberstr.Length;

// if ((length < 5) || (length > 5))
// {
//     Console.WriteLine("Нужно ввести пятизначное число!");
// }
// else
// {
//     if ((numberstr[0] == numberstr[4]) && (numberstr[1] == numberstr[3]))
//     {
//         Console.WriteLine("Введенное число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Введенное число НЕ является палиндромом");
//     }
// }