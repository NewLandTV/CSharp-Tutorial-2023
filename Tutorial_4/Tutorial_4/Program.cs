bool condition = false;

if (condition)
{
    Console.WriteLine("True");
}
else if (!condition)
{
    Console.WriteLine("False");

    int a = 5;
    int b = 0;

    if (a + b == 8)
    {
        Console.WriteLine("a + b = 8");
    }
    else if (a + b == 0)    // (a < b || b >= a) && true
    {
        Console.WriteLine("a + b = 0");
    }
    else
    {
        Console.WriteLine(a + b);
    }
}