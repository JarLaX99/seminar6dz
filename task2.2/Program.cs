// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void main()
{
    double x , y;
    IntersectionPoinX(out x,out y);
    System.Console.WriteLine($"({x};{y})");
}

double ReadDouble(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

void IntersectionPoinX(out double x,out double y)
{
    double b1 = ReadDouble("Введите b1: ");
    double k1 = ReadDouble("Введите k1: ");
    double b2 = ReadDouble("Введите b2: ");
    double k2 = ReadDouble("Введите k2: ");
     x = (b2 - b1) / (k1 - k2);
     y = k1 * x + b1;
}
main();