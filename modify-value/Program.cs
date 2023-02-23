using System;

class Program
{

    public static void Main(String[] args)
    {
        int a = 10;
        int b = 5;
        int c;

        Console.WriteLine($"Before calling ModifyValue: a = {a}, b = {b}");

        ModifyValue(ref a, in b, out c);

        Console.WriteLine($"After calling ModifyValue: a = {a}, b = {b}, c = {c}");

    }

    public static void ModifyValue(ref int a, in int b, out int c)
    {
        a += b;
        c = a - b;
    }

}