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

class Student : Person
{
    private int schoolClass;
    private int grade;

    public Student(int age, string name, int schoolClass, int grade) : base(age, name)
    {
        this.schoolClass = schoolClass;
        this.grade = grade;
    }

    public int GetSchoolClass()
    {
        return schoolClass;
    }

    public int GetGrade()
    {
        return grade;
    }
}

class Test
{
    static void Main()
    {
        Person person = new Person(13, "Test");
        Student student = new Student(11, "Kim student", 2, 5);

        Console.WriteLine("Person Name : " + person.GetName());
        Console.WriteLine("Person Age : " + person.GetAge());
        Console.WriteLine("Student Name : " + student.GetName());
        Console.WriteLine("Student Age : " + student.GetAge());
        Console.WriteLine("Student Class : " + student.GetSchoolClass());
        Console.WriteLine("Student Grade : " + student.GetGrade());
    }
}