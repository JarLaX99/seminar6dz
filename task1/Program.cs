// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

void main()
{   int[] array=Readint("заполните массив через пробел: ");
    PrintArray(array);
    System.Console.WriteLine($"Количество чисел  больше 0 = {NumbersMore0(array)}");
}
int[] Readint(string text)
{
    System.Console.Write(text);
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return array;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join("] [", arrayForPrint) + "]");
}

int NumbersMore0(int[]arr)
{ int count =0;
    foreach(int n in arr)
    {
        if(n>0) count++;
    }
    return count;
}

main();