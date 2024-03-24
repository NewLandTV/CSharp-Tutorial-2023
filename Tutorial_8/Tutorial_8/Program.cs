class Person
{
    private int age;
    private string name;

    public Person(int age, string name)
    {
        this.age = age;
        this.name = name;
    }

    public int GetAge()
    {
        return age;
    }

    public string GetName()
    {
        return name;
    }
}

class Test
{
    static void Main()
    {
        Person person = new Person(13, "Test");
        Person person2 = new Person(21, "가다나");

        Console.WriteLine(person.GetAge());
        Console.WriteLine(person.GetName());
        Console.WriteLine(person2.GetAge());
        Console.WriteLine(person2.GetName());
    }
}