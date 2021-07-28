using System;
using System.Threading;

class Test
{
    static void Main()
    {
        Console.WriteLine("Test");
        Console.WriteLine("             Test2");
        Console.WriteLine("Test3");
        Thread.Sleep(1000);
        ClearLastNLines(3);
        Console.ReadLine();
    }

    public static void ClearLastNLines(int NumberOfLines) 
    {
        int currentLineCursorStart = Console.CursorTop;
        if (Console.CursorTop >= NumberOfLines)
        {
            for (int LineNumber = 0; LineNumber <= NumberOfLines; LineNumber++)
            {
                int currentLineCursor = Console.CursorTop;
                Console.SetCursorPosition(0, Console.CursorTop - LineNumber);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, currentLineCursor);
            }
            Console.SetCursorPosition(0, currentLineCursorStart - NumberOfLines);
        }
        else throw new ApplicationException("Can't clear more lines than available!");
    }
}
