// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int num = ReadInt("Введите целое число");
Console.Write($"{num} ->  ");
Console.WriteLine(Coubes2(num));



//Метод (выдаем таблицу кубов до N)
string Coubes2(int num)
{
    string result = "";
    for (int i = 1; i < num; i++)
    {
        result += $"{i * i * i}, ";
    }
    result += num * num * num;
    return result;
}

//Метод(ввод числа)
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}