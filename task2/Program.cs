// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void main()
{
    double[] array = ReadDouble("Введите b1,k1,b2,k2 через пробел: ");
    array = IntersectionPoin(array);
    PrintArray(array);

}

double[] ReadDouble(string text)
{
    System.Console.Write(text);
    double[] array = Array.ConvertAll(Console.ReadLine()!.Split(), double.Parse);
    return array;
}

void PrintArray(double[] arrayForPrint)
{
    System.Console.WriteLine("(" + string.Join(";", arrayForPrint) + ")");
}

double[] IntersectionPoin(double[] arr)
{
    double[] newArrayXY = new double[2];//выделяем память под x и Y
    newArrayXY[0] = (arr[2] - arr[0]) / (arr[1] - arr[3]);// ищем X по формуле X=(b2-b1)/(k1-k2)
    newArrayXY[1] = arr[1] * newArrayXY[0] + arr[0];//ищем Y по формуле y = k1 * x + b1
    return newArrayXY;
}
main();