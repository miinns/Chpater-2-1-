using System;
class CommentsApp
{
    public static void Main()
    {
        int value = 0;
        char ch;
        Console.Write("Enter a super digit : ");
        ch = (char)Console.Read();
        switch (ch)
        {
            case 'A':
            case 'B':
            case 'C':
            case 'D':
            case 'E':
            case 'F':
                value = ch - 'A' + 10;
                break;
            case 'a':
            case 'b':
            case 'c':
            case 'd':
            case 'e':
            case 'f':
                value = ch - 'a' + 10;
                break;
            default:
                Console.WriteLine(ch + " is not a hexadigit");
                break;
        }
        Console.WriteLine(value);
    }
}
