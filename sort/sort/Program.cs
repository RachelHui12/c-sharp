using System;
public class Test

{
    public static void Main(string[] args)
    {
        string[] ary =
        {

                "Apple", "pineapple", "banana", "cherry",
        };
        Show(ary);
        Array.Sort(ary);
        Show(ary);
        Array.Sort(ary, (a, b) => a.Length - b.Length);
        Show(ary);
        int i = Array.BinarySearch(ary, "Pearl");
        Console.WriteLine(i);
        Array.Reverse(ary);
        Show(ary);
    }
    public static void Show(object[] ary)
    {
        foreach (object obj in ary)
            Console.Write(obj + " ");
        Console.WriteLine();
    }
}
