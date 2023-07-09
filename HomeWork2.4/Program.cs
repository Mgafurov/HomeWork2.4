using System;

class HomeWork
{
    static void Main()
    {
        Console.WriteLine("Введите переменные a , b , c , d : ");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        float d = float.Parse(Console.ReadLine());
        float result = (a * b - c) - (c * d);
        Console.WriteLine("Резульатат : " + result);
        Console.ReadKey();
    }
}