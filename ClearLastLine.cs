using System;
using System.Threading;

class Test
{
    static void Main()
    {
        Console.WriteLine("Test");
        Console.Write("             Test2");
        Thread.Sleep(1000);
        ClearLastNLines(2);
        Console.ReadLine();
    }

    /*public static void ClearCurrentConsoleLine()
    {
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLineCursor);
    }*/

    public static void ClearLastNLines(int NumberOfLines) 
    {
        for(int LineNumber = 0; LineNumber < NumberOfLines; LineNumber++)
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop - LineNumber);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}