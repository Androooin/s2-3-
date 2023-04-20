// Задача 19

// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num = ReadInt("Введите пятизначное число");
if (Result(num) == 1)
{
    Console.WriteLine($"Да число {num} является палиндромом");
}
else if (Result(num) == 2)
{
    Console.WriteLine($"Вы ввели не пятизначное число");
}
else 
{
Console.WriteLine($"Нет число {num} не является палиндромом");
}

Lutsenko();

//Метод (авторство)
void Lutsenko()
{
    Console.WriteLine("                          Автор работы Луценко А.С.");
}
//Метод (узнаем подходит ли нам число и проверяем является ли он палиндромом)
int Result(int Num)
{
    int a = 0;
    int b = 0;
    int c = 0;
    int d = 0;

    if (Num > 9999 && Num < 100000)
    {
        a = Num / 10000;
        b = Num / 1000 % 10;
        c = Num / 10 % 10;
        d = Num % 10;

        if (a == d && b == c)
        {
            Num = 1;
        }
    } 
    else 
    {
        Num = 2;
    }
    return Num;
}
//Метод(ввод числа)
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}