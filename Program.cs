namespace HelloWorldCS;

class Program
{
    public static void Main(string[] args)
    {
        var john = new Person();
        john.FirstName = "John";
        john.LastName = "Smith";
        john.Introduce();
    }
}