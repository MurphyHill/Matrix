using System;
using System.Threading;

class Example
{
    static char GetRandomChar()
    {
        string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789!@#$%^&*(/)><|:}{[]";
        Random r = new Random();
        var index = r.Next(symbols.Length);
        return symbols[index];
    }
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
      
       
        Random x = new Random();
        
        while (true)
        {
            int valueX = x.Next(0, 237);
            int valueY = x.Next(0, 100);

            Console.SetCursorPosition(valueX, valueY);
            Console.WriteLine(GetRandomChar());
        }
    }
}