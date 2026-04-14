using System;
using System.Threading;

public static class Utils
{
    public static void TypeEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(25);
        }
        Console.WriteLine();
    }
}
