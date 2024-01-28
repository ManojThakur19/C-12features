using System.Runtime.CompilerServices;

Console.WriteLine("Default Values for Lambda Expressions");


SumNumber(2,5);

var incrementValue = (int source, int increment = 7) => source + increment;

Console.WriteLine(incrementValue(2));



int SumNumber(int a, int b = 10)
{
    return a + b;
}

var SumNumber1 = (int a, int b = 10) => a + b;

Console.WriteLine(SumNumber1(2, 4));

