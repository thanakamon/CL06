using System;

class Program
{
    static void Main()
    {
        int val;   // do not initial value
        refMethod(ref );
        Console.WriteLine(val);
        Console.ReadLine();
    }

    static void refMethod(ref int i)
    {
        

        i = i + 1;
        
    }
}





