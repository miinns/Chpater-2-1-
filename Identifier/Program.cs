using System;
class IdentifierApp
{
    public static void Main()
    {
        int MyVar = 1, myvar = 2; // 값 지정
        int @int = 10, 변수 = 20; // 한글을 식별자로 사용
        Console.WriteLine("MyVar = " + MyVar + ", myvar = " + myvar);
        Console.WriteLine("@int = " + @int + ", 변수 = " + 변수);
    }
}