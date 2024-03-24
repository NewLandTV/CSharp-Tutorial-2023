void Print()
{
    Console.WriteLine("Print");
}

int Add(int a, int b)
{
    return a + b;
}

void Write(string message, bool nextLine = false)
{
    if (nextLine)
    {
        Console.WriteLine(message);
    }
    else
    {
        Console.Write(message);
    }
}

Print();

Console.WriteLine(Add(10, 5));

Write("Hello ");
Write("World!", true);
Write("Hi!", false);