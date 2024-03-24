for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

int j = 0;

while (true)
{
    Console.WriteLine("While");

    j++;

    if (j >= 10)
    {
        break;
    }
}

Console.WriteLine("End");