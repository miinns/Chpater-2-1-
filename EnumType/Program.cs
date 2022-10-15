using System;
enum Color { Red, Green, Blue };
class EnumTypeApp
{
    public static void Main()
    {
        Color c = Color.Red;
        c++;
        int i = (int)c; //정수형 변환
        Console.WriteLine("Cardinality of " + c + " = " + i);
    }
}