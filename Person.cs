namespace HelloWorldCS;

public class Person
{
    private readonly string _firstName;
    private readonly string _lastName;

    public Person(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public void Introduce()
    {
        Console.WriteLine("My name is {0} {1}", _firstName, _lastName);
    }
}
