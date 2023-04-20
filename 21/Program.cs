// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 
// 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double x1 = ReadInt("Введите координату точки X1");
double y1 = ReadInt("Введите координату точки Y1");
double z1 = ReadInt("Введите координату точки Z1");

double x2 = ReadInt("Введите координату точки X2");
double y2 = ReadInt("Введите координату точки Y2");
double z2 = ReadInt("Введите координату точки Z2");

double a = Diff(x1, x2);
double b = Diff(y1, y2);
double c = Diff(z1, z2);

double result = Distance(a, b, c);

Console.WriteLine($"А {Sign(x1, y1, z1)}; B {Sign(x2, y2, z2)} -> {round(result)}");

Lutsenko();



//Метод (округляем ответ)
double round(double Result)
{
double res = Math.Round(Result, 2);
return res;
}
//Метод (сокращаем вывод на экран)
string Sign(double  A, double B, double C)
{
   string res = $"({A}, {B}, {C})";
   return res;
}
//Метод (находим разницу между точками координат)
double Diff(double Num1, double Num2)
{
    double res = Num1 - Num2;
    return res;
}
//Метод (находим расстояние между точками)
double Distance(double A, double B, double C)
{
    double res = Math.Sqrt(A * A + B * B + C * C);
    return res;
}
//Метод (ввод координат точек)
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
//Метод (авторство)
void Lutsenko()
{
    Console.WriteLine("                                    Работу выполнил Луценко А.С.");
}