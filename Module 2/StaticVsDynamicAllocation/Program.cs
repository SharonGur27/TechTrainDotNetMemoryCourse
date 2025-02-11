using System;
using System.Collections.Generic;

class Program
{
    // Static memory allocation
    static int _staticVariable = 41;

    static void Main(string[] args)
    {
        int _variable = 42;

        // Dynamic memory allocation
        List<int> dynamicArray = [];

        // Example usage
        dynamicArray.Add(1);
        dynamicArray.Add(2);
        dynamicArray.Add(3);

        Console.WriteLine("Variable: " + _variable);
        Console.WriteLine("Static Variable: " + _staticVariable);
        Console.WriteLine("Dynamic Array: " + string.Join(", ", dynamicArray));

        GC.Collect();
    }
}
