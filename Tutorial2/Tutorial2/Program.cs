// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");
Console.WriteLine("Feautre1");


Console.WriteLine("Hello, World!");

Console.WriteLine("Feautre2");

Console.WriteLine("Feautre3");

Console.WriteLine("Feautre4");

Console.WriteLine("Feautre5");


 static int CalculateMax(int[] values)
{
    
    int max = values[0];
    for (int i = 1; i < values.Length; i++)
    {
        if (values[i] > max)
        {
            max = values[i];
        }
    }
    return max;
}