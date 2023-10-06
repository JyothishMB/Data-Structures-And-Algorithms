// See https://aka.ms/new-console-template for more information
using Recursion;

Console.WriteLine("Hello, World!");

Console.WriteLine("Factorial");
RecursionDemo r = new RecursionDemo();
Console.WriteLine(r.CalculateFactorial(10));
Console.WriteLine(r.CalculateSumofNNaturalNumbers(10));

Console.ReadKey();